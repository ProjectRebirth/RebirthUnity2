using UnityEngine;
using System.Collections;

public class AssaultRifleAnimations : MonoBehaviour {
	public BaseGunStats assaultRifle;
	public Animator rifleAnimator;

	void Update() {
		//print (assaultRifle.getIsLookingUp ());
		rifleAnimator.SetBool("isLookingUp", assaultRifle.getIsLookingUp ());
		rifleAnimator.SetBool ("isFiring", assaultRifle.getIsFiring ());
		rifleAnimator.SetFloat ("ammoRatio", assaultRifle.getAmmoRatio ());
		rifleAnimator.SetBool ("isReloading", assaultRifle.getIsReloading ());

	}
}
