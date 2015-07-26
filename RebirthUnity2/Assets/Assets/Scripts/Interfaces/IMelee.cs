using UnityEngine;
using System.Collections;

public interface IMelee {
	bool checkCanMeleeAttack();
	bool checkIsAttacking();
	void meleeAttack(bool meleeButtonDown);

}