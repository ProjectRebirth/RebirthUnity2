using UnityEngine;
using System.Collections;

public class EnableAttackCollider : MonoBehaviour {
	public Collider2D attackCollider;
	public BaseSpriteStats meleeStats;
	public IMeleeStats stats;
	public float attackDelay;
	private float attackDelayTimer;

	void Start() {
		stats = (IMeleeStats)meleeStats;
	}

	void Update() {
		//updateDelayTimer ();
		//checkIsEnabled ();

	}

	private void checkIsEnabled() {
		if (stats.getIsAttacking () && attackDelayTimer <= 0) {
			attackCollider.enabled = true;
		} else {
			attackCollider.enabled = false;
		}
	}



	private void updateDelayTimer() {
		if (stats.getIsAttacking ()) {
			attackDelayTimer -= Time.deltaTime;
			if (attackDelayTimer < 0) {
				attackDelayTimer = 0;
			}
		} else {
			attackDelayTimer = attackDelay;
		}
	}
}
