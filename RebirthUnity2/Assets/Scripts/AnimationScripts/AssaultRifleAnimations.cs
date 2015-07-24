using UnityEngine;
using System.Collections;

public class AssaultRifleAnimations : MonoBehaviour {
	public BaseGunStats assaultRifle;
	public Animator rifleAnimator;

	void Update() {
		//print (assaultRifle.getIsLookingUp ());
		rifleAnimator.SetBool("isLookingUp", assaultRifle.getIsLookingUp ());
		print (assaultRifle.getIsFiring ());
		rifleAnimator.SetBool ("isFiring", assaultRifle.getIsFiring ());
	}
}
