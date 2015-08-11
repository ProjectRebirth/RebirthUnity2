using UnityEngine;
using System.Collections;

public class EnableAttackCollider : MonoBehaviour {
	public Collider2D attackCollider;
	public MeleeWeaponStats meleeStats;
	public float delayEnable;//The amount of time when the sprite begins his attack and when the box will be active for attack.
	private float delayEnableTimer;

	void Update() {
		updateDelayEnableTimer ();
		if (meleeStats.getIsAttacking ()) {
			if (delayEnableTimer <= 0) {
				attackCollider.enabled = true;
			}

		} else {
			attackCollider.enabled = false;
			delayEnableTimer = delayEnable;
		}
	}

	void updateDelayEnableTimer() {
		delayEnableTimer -= Time.deltaTime;
		if (delayEnableTimer < 0) {
			delayEnableTimer = 0f;
		}
	}
}
