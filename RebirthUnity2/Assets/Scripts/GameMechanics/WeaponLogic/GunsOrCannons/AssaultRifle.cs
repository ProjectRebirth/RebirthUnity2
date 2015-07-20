using UnityEngine;
using System.Collections;

public class AssaultRifle : GunLogic {
	private BaseGunStats rifleStats;

	protected override void Start() {
		rifleStats = baseGunStats;
	}

	public override void fireWeapon() {

		GameObject newBullet = (GameObject)Instantiate (rifleStats.projectile.gameObject, transform.position, new Quaternion ());
	}

	public override void reload() {

	}
}
