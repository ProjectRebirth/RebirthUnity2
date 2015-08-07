using UnityEngine;
using System.Collections;

public class EnableAttackCollider : MonoBehaviour {
	public Collider2D attackCollider;
	public MeleeWeaponStats meleeStats;


	void Update() {
		if (meleeStats.getIsAttacking ()) {
			attackCollider.enabled = true;
		} else {
			attackCollider.enabled = false;
		}
	}
}
