using UnityEngine;
using System.Collections;

public class AssaultRifle : GunLogic {
	private BaseGunStats rifleStats;

	protected override void Start() {
		rifleStats = baseGunStats;
	}

	public override void fireWeapon() {
		if (!rifleStats.getIsFiring () && !baseGunStats.getIsEmpty()) {
			GameObject newBullet = (GameObject)Instantiate (rifleStats.projectile.gameObject, transform.position, new Quaternion ());
			ProjectileStats bulletStats = newBullet.GetComponent<ProjectileStats>();
			bool isRight = rifleStats.weaponOwner.getIsRight();
			if (isRight) {
				bulletStats.setDirection(new Vector2(1, 0));
			}
			else {
				bulletStats.setDirection(new Vector2(-1, 0));
			}
			rifleStats.resetCoolDownTimer();
			baseGunStats.decrementCurrentMagazine();
		}
	}

	public override void reload() {
		rifleStats.setCurrentMagazine (rifleStats.maxMagazine);
	}
}
