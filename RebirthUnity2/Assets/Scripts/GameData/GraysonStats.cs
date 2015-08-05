using UnityEngine;
using System.Collections;

public class GraysonStats : BaseSpriteStats, IShooterStats {
	public AssaultRifle assaultRifle;
	public BaseGunStats rifleStats;

	public bool getIsFiring() {
		return rifleStats.getIsFiring ();
	}
}
