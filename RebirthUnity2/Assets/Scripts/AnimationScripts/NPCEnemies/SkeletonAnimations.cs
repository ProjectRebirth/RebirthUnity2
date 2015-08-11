using UnityEngine;
using System.Collections;

public class SkeletonAnimations : MonoBehaviour {
	public SkeletonStats skeletonStats;
	public Animator skeletonAnimator;

	// Update is called once per frame
	void Update () {
		skeletonAnimator.SetBool ("isWalking", skeletonStats.getIsWalking ());
		skeletonAnimator.SetBool ("isDead", skeletonStats.getIsDead ());
		skeletonAnimator.SetBool ("isAttacking", skeletonStats.getIsAttacking ());
	}
}
