using UnityEngine;
using System.Collections;

public class BatBlaster : GunLogic {
	public Transform target;

	public override void fireWeapon() {
		if (checkCanFire ()) {
			GameObject projectile = (GameObject)Instantiate (baseGunStats.projectile.gameObject, transform.position, new Quaternion ());
			float x = target.position.x - transform.position.x;
			float y = target.position.y - transform.position.y;

			projectile.GetComponent<ProjectileStats> ().setDirection (new Vector2 (x, y));
			baseGunStats.resetCoolDownTimer();
		}
	}


	private bool checkCanFire() {
		return !baseGunStats.getIsFiring ();
	}
	public override void reload() {

	}


}
