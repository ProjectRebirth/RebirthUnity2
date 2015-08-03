using UnityEngine;
using System.Collections;

public class TigerStats : BaseSpriteStats, IMeleeStats {
	public float attackTime;
	public float attackCoolDown;
	private float attackTimer;
	private float coolDownTimer;


	protected virtual void Update() {
		updateAttackTimer ();
		updateCoolDown ();
	}

	private void updateCoolDown() {

		if (getIsAttacking ()) {
			coolDownTimer = attackTimer;
		}
		coolDownTimer -= Time.deltaTime;
		if (coolDownTimer < 0) {
			coolDownTimer = 0;
		}

	}

	public bool getCoolDownAttack() {
		return coolDownTimer <= 0;
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
