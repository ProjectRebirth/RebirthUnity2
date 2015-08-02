using UnityEngine;
using System.Collections;

public class TigerMechanics : BaseMechanics, IMelee {
	public TigerStats tigerStats;

	protected override void Start() {

	}

	public bool checkCanMeleeAttack() {
		return false;
	}

	public void meleeAttack(bool meleeButtonDown) {
		if (checkCanMeleeAttack ()) {

		}
	}


}
