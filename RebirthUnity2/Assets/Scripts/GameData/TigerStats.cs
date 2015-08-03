using UnityEngine;
using System.Collections;

public class TigerStats : BaseSpriteStats, IMeleeStats {
	public float attackTime;
	private float attackTimer;


	protected virtual void Update() {
		updateAttackTimer ();
	}

	public bool getIsAttacking() {
		return attackTimer > 0;
	}

	private void updateAttackTimer() {
		attackTimer -= Time.deltaTime;
		if (attackTimer < 0) {
			attackTimer = 0;
		}
	}

	public void resetAttackTimer() {
		attackTimer = attackTime;
	}
}
