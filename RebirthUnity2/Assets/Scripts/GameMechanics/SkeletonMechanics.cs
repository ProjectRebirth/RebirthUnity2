﻿using UnityEngine;
using System.Collections;

public class SkeletonMechanics : BaseMechanics, IShooter, IMelee {
	private SkeletonStats skeletonStats;


	protected override void Start() {
		base.Start ();
		skeletonStats = (SkeletonStats)baseStats;
	}


	public void fireWeapon(bool fireWeaponDown) {
		if (checkCanFire () && fireWeaponDown) {
			skeletonStats.cannonMechanics.fireWeapon();
		}
	}

	public bool checkCanFire() {
		return true;
	}

	public void reloadMain(bool reloadButtonDown) {
		if (checkCanReload ()) {
			skeletonStats.cannonMechanics.reload();
		}
	}


	public bool checkCanReload() {
		return false;
	}


	public void meleeAttack(bool attackButtonDown) {
		if (checkCanMeleeAttack () && attackButtonDown) {
			skeletonStats.swordMechanics.attack ();
		}
	}

	public bool checkCanMeleeAttack() {
		return !skeletonStats.getIsAttacking();
	}
}
