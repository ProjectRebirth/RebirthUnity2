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

	public void strafe(bool strafeButtonDown) {

		if (checkCanStrafe ()) {
			if (strafeButtonDown) {
				launchStrafe();
			}
		}
	}

	void launchStrafe() {
		Rigidbody2D rigid = GetComponent<Rigidbody2D> ();
		float x = graysonStats.strafeDirection.x;
		float y = graysonStats.strafeDirection.y;
		if (!graysonStats.getIsRight ()) {
			x = -x;
		}

		rigid.velocity = new Vector2 (x, y) * graysonStats.strafeSpeed;
		graysonStats.resetStrafeCoolDown ();
	}

	bool checkCanStrafe() {
		return graysonStats.getStrafeCDRatio () >= 1;
	}


	/// <summary>
	/// This override just makes it so that when Grayson jumps, it will cause the player to detatch from climbing
	/// a ladder or rope.
	/// </summary>
	/// <param name="jumpButtonDown">If set to <c>true</c> jump button down.</param>
	public override void jump(bool jumpButtonDown) {
		if (graysonStats.getInAir () && jumpButtonDown) {
			graysonStats.climbMechanics.detatchClimb();
		}
		base.jump (jumpButtonDown);
	}
}
