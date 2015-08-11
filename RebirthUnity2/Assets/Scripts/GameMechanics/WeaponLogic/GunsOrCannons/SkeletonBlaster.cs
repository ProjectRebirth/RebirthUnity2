using UnityEngine;
using System.Collections;

public class SkeletonBlaster : GunLogic {
	private SkeletonBlasterStats blasterStats;
	public float delayShot;
	private float delayShotTimer;
	private bool shotFired;

	protected override void Start() {
		base.Start ();
		blasterStats = (SkeletonBlasterStats)baseGunStats;
	}

	protected override void Update() {

		base.Update ();
		updateShootWeapon ();
	}

	public override void fireWeapon() {
		if (blasterStats.getNextShotReady()) {
			shotFired = true;
			delayShotTimer = delayShot;
			blasterStats.resetNextShotTimer();
		}
	}

	void updateShootWeapon() {
		delayShotTimer -= Time.deltaTime;
		if (delayShotTimer < 0) {
			if (shotFired) {
				blasterStats.resetNextShotTimer();
				GameObject bullet = (GameObject)Instantiate(blasterStats.projectile.gameObject, 
				                                            baseGunStats.launchPositions[0].position, new Quaternion());
				bullet.GetComponent<ProjectileStats>().setWeaponOrigin(blasterStats);
				if (blasterStats.weaponOwner.getIsRight()) {
					bullet.GetComponent<ProjectileStats>().setDirection(new Vector2(1, 0));
				}
				else {
					bullet.GetComponent<ProjectileStats>().setDirection(new Vector2(-1, 0));
				}
				baseGunStats.resetCoolDownTimer();
				shotFired = false;
			}
			delayShotTimer = 0;
		}
	}

	public override void reload() {


	}
}
