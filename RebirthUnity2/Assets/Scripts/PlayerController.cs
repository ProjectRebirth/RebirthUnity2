using UnityEngine;
using System.Collections;

/// <summary>
/// This PlayerController will be used by the player for his ground Unit
/// Other controllers will be added as needed for different situations
/// </summary>
public class PlayerController : MonoBehaviour {
	public BaseMechanics mechanics;

	void Update() {
		float horizontalMovement = Input.GetAxisRaw ("Horizontal");
		float verticalMovement = Input.GetAxisRaw ("Vertical");
		bool jumpKeyDown = Input.GetButton ("Jump");

		mechanics.moveVertical (verticalMovement);
		mechanics.moveHorizontal (horizontalMovement);
		mechanics.jump (jumpKeyDown);

	}

	void FixedUpdate() {

	}

	void Start() {

	}


}
