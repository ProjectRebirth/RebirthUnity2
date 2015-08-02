using UnityEngine;
using System.Collections;

public class TigerMechanics : BaseMechanics, IMelee {
	private TigerStats tigerStats;

	protected override void Start() {
		tigerStats = (TigerStats)baseStats;
	}

	public bool checkCanMeleeAttack() {
		return !tigerStats.getIsAttacking ();
	}

	public void meleeAttack(bool meleeButtonDown) {
		if (checkCanMeleeAttack () && meleeButtonDown) {
			tigerStats.resetAttackTimer();
		}
	}


}
