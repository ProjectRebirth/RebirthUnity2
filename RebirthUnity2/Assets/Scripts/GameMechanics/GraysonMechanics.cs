using UnityEngine;
using System.Collections;

public class GraysonMechanics : BaseMechanics, IShooter {
	public AssaultRifle assaultRifle;
	public BaseGunStats rifleStats;

	public void fireWeapon(bool fireWeaponDown) {
		if (checkCanFire () && fireWeaponDown) {
			assaultRifle.fireWeapon();
		}
	}

	public bool getIsFiring() {
		return rifleStats.getIsFiring();
	}

	/// <summary>
	/// This method is from IShooter. It is used to check any restrictions to allowing the sprite from firing their weapon.
	/// Currently there are no restricitons, but please add them as you see fit.
	/// </summary>
	/// <returns><c>true</c>, if can fire was checked, <c>false</c> otherwise.</returns>
	public bool checkCanFire() {
		return true;
	}

	public void reloadMain(bool reloadDown) {
		if (reloadDown && checkCanReload()) {
			assaultRifle.reload ();
		}
	}

	private bool checkCanReload() {
		return !rifleStats.getIsFiring();
	}

}
