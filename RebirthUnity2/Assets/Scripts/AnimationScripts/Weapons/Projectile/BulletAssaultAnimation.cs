using UnityEngine;
using System.Collections;

public class BulletAssaultAnimation : MonoBehaviour {
	public Animator bulletAnimator;
	public ProjectileStats bulletStats;
	
	// Update is called once per frame
	void Update () {
		bulletAnimator.SetBool ("hasCollided", bulletStats.getHasCollided ());
	}
}
