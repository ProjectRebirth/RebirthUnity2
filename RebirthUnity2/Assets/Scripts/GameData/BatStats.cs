using UnityEngine;
using System.Collections;

public class BatStats: BaseSpriteStats {
	public float verticalMomentum;

	void Start() {
		if (verticalMomentum == 0) {
			verticalMomentum = horizontalMomentum;
		}
	}

	public float getVerticalSpeed() {
		Rigidbody2D rigid = GetComponent<Rigidbody2D> ();
		return rigid.velocity.y;
	}

	public float getVerticalMomentum() {
		return verticalMomentum;
	}
}
