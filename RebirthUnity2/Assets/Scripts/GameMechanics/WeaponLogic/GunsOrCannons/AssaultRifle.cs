using UnityEngine;
using System.Collections;

public class AssaultRifle : GunLogic {

	public override void fireWeapon() {
		GameObject newBullet = (GameObject)Instantiate (projectile.gameObject, transform.position, new Quaternion ());



	}
}
