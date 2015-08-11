using UnityEngine;
using System.Collections;

public class ClimbMechanics : MonoBehaviour {
	public BaseSpriteStats spriteStats;
	private Collider2D canClimb;//This checks if the player is currently in front of a lader
	private bool isClimbing;//This checks if the sprite is currently climbing a rope or ladder
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "Climable") {
			canClimb = true;
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.tag == "Climable") {
			canClimb = false;
		}
	}

	public void attachClimbable() {
		if (canClimb) {
			isClimbing = true;
		}
	}

	public void detatchClimbable() {

	}
}
