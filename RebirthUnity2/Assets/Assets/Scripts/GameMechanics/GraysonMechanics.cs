using UnityEngine;
using System.Collections;

public class GraysonMechanics : BaseMechanics, IShooter {
	public GraysonStats graysonStats;

	protected override void Start() {
		base.Start ();
		graysonStats = (GraysonStats)baseStats;
	}

	public void fireWeapon(bool fireWeaponDown) {
		if (checkCanFire () && fireWeaponDown) {
			graysonStats.assaultRifle.fireWeapon();
		}
	}

	public bool getIsFiring() {
		return graysonStats.getIsFiring();
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
			graysonStats.assaultRifle.reload ();
		}
	}

	private bool checkCanReload() {
		return !graysonStats.rifleStats.getIsFiring();
	}

}
