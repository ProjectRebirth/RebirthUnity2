using UnityEngine;
using System.Collections;

/// <summary>
/// This PlayerController will be used by the player for his ground Unit
/// Other controllers will be added as needed for different situations
/// </summary>
public class PlayerController : MonoBehaviour {
	public GraysonMechanics mechanics;

	void Update() {

		mechanics.fireWeapon (Input.GetButton("FireMain"));
		mechanics.reloadMain (Input.GetButtonDown ("Reload"));
		mechanics.strafe (Input.GetButtonDown ("Strafe"));

	}

	void FixedUpdate() {
		float horizontalMovement = Input.GetAxisRaw ("Horizontal");
		float verticalMovement = Input.GetAxisRaw ("Vertical");
		mechanics.moveVertical (verticalMovement);
		mechanics.moveHorizontal (horizontalMovement);
		bool jumpKeyDown = Input.GetButtonDown ("Jump");
		
		
		mechanics.jump (jumpKeyDown);
	}

	void Start() {

	}


}
