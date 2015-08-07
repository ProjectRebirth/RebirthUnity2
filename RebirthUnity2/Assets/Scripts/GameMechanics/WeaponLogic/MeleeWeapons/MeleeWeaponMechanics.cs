using UnityEngine;
using System.Collections;

public class MeleeWeaponMechanics : MonoBehaviour {
	public MeleeWeaponStats meleeStats;	

	public void attack() {
		if (checkCanAttack ()) {
			meleeStats.resetAttackTimer();
			meleeStats.resetCoolDownTimer();
		}
	}
		
	
	protected virtual bool checkCanAttack() {
		return !meleeStats.getIsAttacking() && meleeStats.getIsCooledDown();
	}


}
