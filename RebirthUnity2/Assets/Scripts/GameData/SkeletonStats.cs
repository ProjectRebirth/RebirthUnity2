using UnityEngine;
using System.Collections;

public class SkeletonStats : BaseSpriteStats, IShooterStats, IMeleeStats {
	public GunLogic cannonMechanics;
	public BaseGunStats cannonStats;
	public MeleeWeaponMechanics swordMechanics;
	public MeleeWeaponStats swordStats;


	public bool getIsFiring() {
		return cannonStats.getIsFiring();
	}



	/// <summary>
	/// This regerences the skeleton's sword attack just in case that's not clear from the 
	/// method name.
	/// </summary>
	/// <returns><c>true</c>, if is attacking was gotten, <c>false</c> otherwise.</returns>
	public bool getIsAttacking() {
		return swordStats.getIsAttacking ();
	}
}
