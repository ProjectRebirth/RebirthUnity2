using UnityEngine;
using System.Collections;

public class ClimbMechanics : MonoBehaviour {
	public BaseSpriteStats spriteStats;
	public float climbSpeed;
	private Collider2D canClimb;//This checks if the player is currently in front of a lader
	private bool isClimbing;//This checks if the sprite is currently climbing a rope or ladder

	void Update() {
		adjustSpritePosition ();
	}

	void adjustSpritePosition() {
		if (isClimbing) {
			float x = canClimb.transform.position.x;
			float y = spriteStats.transform.position.y;
			float z = spriteStats.transform.position.z;
			spriteStats.transform.position = new Vector3(x, y, z);

		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "Climable") {
			canClimb = collider;
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.tag == "Climable") {
			canClimb = null;
			detatchClimbable();
		}
	}

	public void attachClimbable() {
		if (canClimb) {
			isClimbing = true;
		}
	}

	public void detatchClimbable() {
		if (isClimbing) {
			isClimbing = false;
		}
	}

	public bool getIsClimbing() {
		return isClimbing;
	}

	public void setIsClimbing(bool isClimbing) {
		this.isClimbing = isClimbing;
	}
}
