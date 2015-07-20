using UnityEngine;
using System.Collections;

/// <summary>
/// This PlayerController will be used by the player for his ground Unit
/// Other controllers will be added as needed for different situations
/// </summary>
public class PlayerController : MonoBehaviour {
	public GraysonMechanics mechanics;

	void Update() {
		float horizontalMovement = Input.GetAxisRaw ("Horizontal");
		float verticalMovement = Input.GetAxisRaw ("Vertical");
		bool jumpKeyDown = Input.GetButtonDown ("Jump");

		mechanics.moveVertical (verticalMovement);
		mechanics.moveHorizontal (horizontalMovement);
		mechanics.jump (jumpKeyDown);
		mechanics.fireWeapon (Input.GetButton("FireMain"));

	}

	void FixedUpdate() {

	}

	void Start() {

	}


}
