using UnityEngine;
using System.Collections;

public class TigerAnimations : MonoBehaviour {
	public TigerStats tigerStats;
	public Animator tigerAnimator;

	void Update() {
		tigerAnimator.SetBool ("isDead", tigerStats.getIsDead ());
		tigerAnimator.SetBool ("isAttacking", tigerStats.getIsAttacking ());
		tigerAnimator.SetBool ("isWalking", tigerStats.getIsWalking ());
	}

}
