using UnityEngine;
using System.Collections;

public class BatController : MonoBehaviour {
	public BatMechanics batMechanics;

	// Update is called once per frame
	void Update () {
		batMechanics.moveVertical(Input.GetAxisRaw("Vertical"));
		batMechanics.moveHorizontal (Input.GetAxisRaw ("Horizontal"));

	}
}
