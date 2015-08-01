using UnityEngine;
using System.Collections;

public class BatAnimation : MonoBehaviour {
	public BatStats batStats;
	public Animator batAnimator;
	// Update is called once per frame
	void Update () {
		batAnimator.SetBool ("isDead", batStats.getIsDead ());
		batAnimator.SetFloat ("verticalSpeed", Mathf.Abs (batStats.getVerticalSpeed ()));
	}
}
