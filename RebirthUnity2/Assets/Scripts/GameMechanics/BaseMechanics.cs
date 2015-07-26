using UnityEngine;
using System.Collections;

public class BaseMechanics : MonoBehaviour {
	public BaseSpriteStats baseStats;
	private float goalWalkSpeed;

	// Use this for initialization
	protected virtual void Start () {
		orientPlayer ();
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		orientPlayer ();
	}


	/// <summary>
	/// This method is used to flip the texture of the sprite based on the direction that they are facing.
	/// </summary>
	protected virtual void orientPlayer() {
		bool isRight = baseStats.getIsRight ();
		Vector3 scale = transform.localScale;

		if (isRight && scale.x < 0) {
			transform.localScale = new Vector3 (1, scale.y, scale.z);
		} else if (!isRight && scale.x > 0) {
			transform.localScale = new Vector3(-1, scale.y, scale.z);
		}
	}

	protected virtual void FixedUpdate() {
		updateHorizontalMovement ();
		updateVerticalMovement ();
	}

	/// <summary>
	/// This method does not move the player. Instead it sets up the speed and direction that the player wants to move toward
	/// as it updates.
	/// </summary>
	/// <param name="horizontalInput">Horizontal input.</param>
	public virtual void moveHorizontal(float horizontalInput) {
		baseStats.setLastHorizontalInput (horizontalInput);
		if (horizontalInput > 0) {
			baseStats.setIsRight (true);
		} else if (horizontalInput < 0) {
			baseStats.setIsRight (false);
		}
		goalWalkSpeed = horizontalInput * baseStats.getSpeed ();
	}

	public virtual void moveVertical(float verticalInput) {
		baseStats.setLastVerticalInput (verticalInput);
	}

	public virtual void jump(bool jumpButtonDown) {
		Rigidbody2D rigid = GetComponent<Rigidbody2D> ();
		if (!baseStats.getInAir () && jumpButtonDown) {
			float x = rigid.velocity.x;
			float y = baseStats.jumpSpeed;
			rigid.velocity = new Vector2(x, y);
		}
	}

	protected virtual void updateHorizontalMovement() {
		Rigidbody2D rigid = GetComponent<Rigidbody2D> ();
		float currentX = rigid.velocity.x;
		float x = Mathf.MoveTowards (currentX, goalWalkSpeed, Time.deltaTime * baseStats.getHorizontalMomentum());
		rigid.velocity = new Vector2 (x, rigid.velocity.y);
	}

	protected virtual void updateVerticalMovement() {

	}




}
