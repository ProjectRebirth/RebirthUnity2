using UnityEngine;
using System.Collections;

public class BaseMechanics : MonoBehaviour {
	public BaseSpriteStats baseStats;
	private float goalWalkSpeed;

	// Use this for initialization
	protected virtual void Start () {
	
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		
	}

	protected virtual void FixedUpdate() {
		updateHorizontalMovement ();
		updateVerticalMovement ();

	}

	public virtual void moveHorizontal(float horizontalInput) {
		goalWalkSpeed = horizontalInput * baseStats.getSpeed ();
	}

	public virtual void moveVertical(float verticalInput) {

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
