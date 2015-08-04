using UnityEngine;
using System.Collections;

public class TigerController : MonoBehaviour {
	public TigerMechanics mechanics;
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		mechanics.moveHorizontal (Input.GetAxisRaw ("Horizontal"));
		mechanics.meleeAttack (Input.GetKey (KeyCode.J));
	}
}
