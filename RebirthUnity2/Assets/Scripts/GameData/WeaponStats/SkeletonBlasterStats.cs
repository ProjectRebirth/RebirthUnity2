using UnityEngine;
using System.Collections;

public class SkeletonBlasterStats : BaseGunStats {
	public float nextShotTime;
	private float nextShotTimer;

	protected override void Update() {
		base.Update ();
		updateNextShotTimer ();

	}

	void updateNextShotTimer() {
		nextShotTimer -= Time.deltaTime;
		if (nextShotTimer < 0) {
			nextShotTimer = 0;
		}
	}

	public bool getNextShotReady() {
		return nextShotTimer <= 0;
	}

	public void resetNextShotTimer() {
		nextShotTimer = nextShotTime;
	}
}