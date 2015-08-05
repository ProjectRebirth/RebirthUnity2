using UnityEngine;
using System.Collections;

public class BatStats: BaseSpriteStats, IShooterStats {
	public float verticalMomentum;
	public BaseGunStats weaponStats;
	public BatBlaster weaponMechanics;

	void Start() {
		if (verticalMomentum == 0) {
			verticalMomentum = horizontalMomentum;
		}
	}

	void Update() {

	}

	public float getVerticalSpeed() {
		Rigidbody2D rigid = GetComponent<Rigidbody2D> ();
		return rigid.velocity.y;
	}

	public float getVerticalMomentum() {
		return verticalMomentum;
	}

	public bool getIsFiring() {
		return weaponStats.getIsFiring ();
	}
}
