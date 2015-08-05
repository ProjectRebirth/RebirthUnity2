using UnityEngine;
using System.Collections;

public interface IMelee {
	bool checkCanMeleeAttack();
	void meleeAttack(bool meleeButtonDown);

}