using UnityEngine;
using System.Collections;

public class AssaultRifleAnimations : MonoBehaviour {
	public GunLogic assaultRifle;
	public Animator rifleAnimator;

	void Update() {
		//print (assaultRifle.getIsLookingUp ());
		rifleAnimator.SetBool("isLookingUp", assaultRifle.getIsLookingUp ());
	}
}
