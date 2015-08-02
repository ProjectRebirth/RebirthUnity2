using UnityEngine;
using System.Collections;

public class EnableAttackCollider : MonoBehaviour {
	public Collider2D attackCollider;
	public IMeleeStats meleeStats;
	public float attackDelay;
	private float attackDelayTimer;

	void Update() {
		updateDelayTimer ();
		if (meleeStats.getIsAttacking () && attackDelayTimer <= 0) {
			attackCollider.enabled = true;
		} else {
			attackCollider.enabled = false;
		}

	}



	private void updateDelayTimer() {
		if (meleeStats.getIsAttacking ()) {
			attackDelayTimer -= Time.deltaTime;
			if (attackDelayTimer < 0) {
				attackDelayTimer = 0;
			}
		} else {
			attackDelayTimer = attackDelay;
		}
	}
}
