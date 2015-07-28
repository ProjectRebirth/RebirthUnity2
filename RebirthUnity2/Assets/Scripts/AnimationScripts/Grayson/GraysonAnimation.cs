using UnityEngine;
using System.Collections;

public class GraysonAnimation : MonoBehaviour {
	public Animator legAnimator;
	public Animator torsoAnimator;
	public BaseSpriteStats graysonStats;

	// Update is called once per frame
	void Update () {
		legAnimator.SetBool ("isWalking", graysonStats.getIsWalking ());
		legAnimator.SetBool ("inAir", graysonStats.getInAir ());
		torsoAnimator.SetBool ("isWalking", graysonStats.getIsWalking());
		torsoAnimator.SetBool ("inAir", graysonStats.getInAir ());
	}
}
