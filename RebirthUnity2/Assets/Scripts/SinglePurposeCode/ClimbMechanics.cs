using UnityEngine;
using System.Collections;

public class ClimbMechanics : MonoBehaviour {
	public BaseSpriteStats spriteStats;

	private Collider2D canClimb;//If the sprite is in the collider of a ladder then can climb will not be null.
	private bool isClimbing;//If the sprite is currently climbing the laddder then this will be set to true.

	void Update() {
		updateIsClimbing ();
		if (isClimbing) {
			updateClimbLogic ();
		}

	}

	/// <summary>
	/// if isClimbing is true then this method will be called and handle
	/// all the logic that is involved with the sprite and the climbable object.
	/// </summary>
	void updateClimbLogic() {

	}

	/// <summary>
	/// checks if the conditions for climbing have been met. set isClimbing to true if all the conditiona are true.
	/// </summary>
	void updateIsClimbing() {
		if (checkCanClimb()) {
			isClimbing = true;
		}
	}

	/// <summary>
	/// Conditions that need to all be true before is climbing is set to true.
	/// </summary>
	/// <returns><c>true</c>, if can climb was checked, <c>false</c> otherwise.</returns>
	bool checkCanClimb() {
		return getCanClimb () && !isClimbing && spriteStats.getIsLookingUp ();
	}


	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.tag == "Climbable") {
			canClimb = collider;
		}
	}

	void OnTriggerExit2D (Collider2D collider) {
		if (collider.tag == "Climabable") {
			detatchClimb();
		}
	}

	void detatchClimb() {
		canClimb = null;
		isClimbing = false;
	}

	public bool getCanClimb() {
		return canClimb != null;
	}

	public bool getIsClimbing() {
		return isClimbing;
	}


}
