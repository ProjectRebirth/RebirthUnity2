using UnityEngine;
using System.Collections;

public class TigerAnimations : MonoBehaviour {
	public BaseSpriteStats tigerStats;
	public Animator tigerAnimator;

	void Update() {
		tigerAnimator.SetBool ("isDead", tigerStats.getIsDead ());
	}

}
