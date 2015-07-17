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

	}

	public virtual void moveHorizontal(float horizontalInput) {

	}

	public virtual void moveVertical(float verticalInput) {

	}

	protected virtual void updateHorizontalMovement() {

	}

	protected virtual void updateVerticalMovement() {

	}


}
