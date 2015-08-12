using UnityEngine;
using System.Collections;

public class SkeletonBlasterStats : BaseGunStats {
	public float nextProjectileTime;
	private float npTimer;

	protected override void Update() {
		base.Update ();
		updateNPTimer();
	}

	void updateNPTimer() {
		npTimer -= Time.deltaTime;
		if (npTimer < 0) {
			npTimer = 0;
		}
	}

	public bool getNextShotReady() {
		return npTimer <= 0;
	}

	/// <summary>
	/// NP timer is the Next Projectile timer. This is the time it takes between one projectile to the next
	/// </summary>
	public void resetNPTimer() {
		npTimer = nextProjectileTime;
	}


}