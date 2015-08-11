using UnityEngine;
using System.Collections;

public class SkeletonController : MonoBehaviour {
	public SkeletonMechanics skeletonMechanics;
	// Update is called once per frame
	void Update () {
		bool attackDown = Input.GetKeyDown (KeyCode.J);
		bool fireWeaponDown = Input.GetKeyDown (KeyCode.K);
		skeletonMechanics.fireWeapon (fireWeaponDown);
		skeletonMechanics.meleeAttack (attackDown);

	}

	void FixedUpdate() {
		skeletonMechanics.moveHorizontal(Input.GetAxisRaw("Horizontal"));
	}
}
