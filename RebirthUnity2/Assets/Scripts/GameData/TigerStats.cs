using UnityEngine;
using System.Collections;

public class TigerStats : BaseSpriteStats, IMeleeStats {
	public MeleeWeaponStats meleeWeapon;
	public MeleeWeaponMechanics biteMechanics;


	protected virtual void Update() {

	}

	public bool getIsAttacking() {
		return meleeWeapon.getIsAttacking();
	}

	public bool getCoolDownAttack() {
		return meleeWeapon.getIsCooledDown ();
	}

	public MeleeWeaponStats getMeleeWeapon() {
		return meleeWeapon;
	}

	public MeleeWeaponMechanics getWeaponMechanics() {
		return biteMechanics;
	}

}
