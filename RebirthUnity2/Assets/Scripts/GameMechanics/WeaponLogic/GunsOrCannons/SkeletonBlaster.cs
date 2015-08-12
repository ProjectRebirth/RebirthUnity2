using UnityEngine;
using System.Collections;

public class SkeletonBlaster : GunLogic {
	private SkeletonBlasterStats blasterStats;
	public float delayFireProjectile;
	private float delayShotTimer;
	private bool shotFired;

	protected override void Start() {
		base.Start ();
		blasterStats = (SkeletonBlasterStats)baseGunStats;
		delayShotTimer = delayFireProjectile;

	}
	protected override void Update() {
		base.Update ();
		checkShootProjectile ();
	}


	/// <summary>
	/// This method checks to see when it is appropirate to fire a projectile
	/// </summary>
	void checkShootProjectile() {
		float previousTime = delayShotTimer;
		delayShotTimer += Time.deltaTime;
		if (delayShotTimer > delayFireProjectile) {
			delayShotTimer = delayFireProjectile;
		}
		if (delayShotTimer >= delayFireProjectile && previousTime < delayShotTimer) {
			GameObject obj = (GameObject)Instantiate(blasterStats.projectile.gameObject, 
			                                         blasterStats.launchPositions[0].position, new Quaternion());
			ProjectileStats bullet = obj.GetComponent<ProjectileStats>();
			bullet.setWeaponOrigin(blasterStats);
			if (blasterStats.weaponOwner.getIsRight()) {
				bullet.setDirection(new Vector2(1, 0));
			} else{
				bullet.setDirection(new Vector2(-1, 0));
			}

		}

	}

	public override void fireWeapon() {
		if (blasterStats.getNextShotReady ()) {
			delayShotTimer = 0;
			blasterStats.resetCoolDownTimer();
			blasterStats.resetNPTimer ();
		}
	}



	public override void reload() {

	}
}
