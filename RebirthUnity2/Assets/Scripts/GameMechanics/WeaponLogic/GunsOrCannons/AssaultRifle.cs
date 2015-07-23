using UnityEngine;
using System.Collections;

public class AssaultRifle : GunLogic {
	private BaseGunStats rifleStats;
	const int LAUNCH_UP = 0;
	const int LAUNCH_SIDE = 1;

	protected override void Start() {
		rifleStats = baseGunStats;
	}

	public override void fireWeapon() {
		if (!rifleStats.getIsFiring () && !baseGunStats.getIsEmpty()) {
			bool isRight = rifleStats.weaponOwner.getIsRight();
			bool isUp = rifleStats.weaponOwner.getIsLookingUp();
			Vector3 launchLocation = new Vector3();
			if (isUp) {
				launchLocation = rifleStats.launchPositions[LAUNCH_UP].position;
			} else {
				launchLocation = rifleStats.launchPositions[LAUNCH_SIDE].position;
			}
			GameObject newBullet = (GameObject)Instantiate (rifleStats.projectile.gameObject, launchLocation, new Quaternion ());
			ProjectileStats bulletStats = newBullet.GetComponent<ProjectileStats>();

			if (isUp) {
				bulletStats.setDirection(new Vector2(rifleStats.getRandomSpread(), 1));
			}
			else if (isRight) {
				bulletStats.setDirection(new Vector2(1, rifleStats.getRandomSpread()));
			}
			else {
				bulletStats.setDirection(new Vector2(-1, rifleStats.getRandomSpread()));
			}
			rifleStats.resetCoolDownTimer();
			baseGunStats.decrementCurrentMagazine();
		}
	}

	public override void reload() {
		rifleStats.setCurrentMagazine (rifleStats.maxMagazine);
	}


}
