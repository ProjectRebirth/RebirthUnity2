using UnityEngine;
using System.Collections;

public class SkeletonAnimations : MonoBehaviour {
	public BaseSpriteStats skeletonStats;
	public Animator skeletonAnimator;

	// Update is called once per frame
	void Update () {
		skeletonAnimator.SetBool ("isDead", skeletonStats.getIsDead ());
	}
}
