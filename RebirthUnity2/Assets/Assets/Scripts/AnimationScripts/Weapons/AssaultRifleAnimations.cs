using UnityEngine;
using System.Collections;

public class AssaultRifleAnimations : MonoBehaviour {
	public BaseGunStats assaultRifle;
	public Animator rifleAnimator;
	public Transform walkPosition;
	private Vector3 originalPosition;

	void Start() {
		originalPosition = transform.localPosition;
	}

	void Update() {
		//print (assaultRifle.getIsLookingUp ());
		rifleAnimator.SetBool("isLookingUp", assaultRifle.getIsLookingUp ());
		rifleAnimator.SetBool ("isFiring", assaultRifle.getIsFiring ());
		rifleAnimator.SetFloat ("ammoRatio", assaultRifle.getAmmoRatio ());
		rifleAnimator.SetBool ("isReloading", assaultRifle.getIsReloading ());
		checkIsWalking ();
	}

	void checkIsWalking() {
		if (walkPosition != null) {
			if (assaultRifle.weaponOwner.getIsWalking()) {
				transform.localPosition = walkPosition.localPosition;
			}
			else {
				transform.localPosition = originalPosition;
			}
		}
	}
}
