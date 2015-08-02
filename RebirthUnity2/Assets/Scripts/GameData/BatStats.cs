using UnityEngine;
using System.Collections;

public class BatStats: BaseSpriteStats {
	public float getVerticalSpeed() {
		Rigidbody2D rigid = GetComponent<Rigidbody2D> ();
		return rigid.velocity.y;
	}
}
