using UnityEngine;
using System.Collections;

public class AssaultRifle : GunLogic {
	private BaseGunStats rifleStats;

	protected override void Start() {
		rifleStats = baseGunStats;
	}

	public override void fireWeapon() {
		if (!rifleStats.getIsFiring ()) {
			GameObject newBullet = (GameObject)Instantiate (rifleStats.projectile.gameObject, transform.position, new Quaternion ());
			rifleStats.resetCoolDownTimer();
		}
	}

	public override void reload() {

	}
}
