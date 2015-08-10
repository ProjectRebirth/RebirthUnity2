using UnityEngine;
using System.Collections;

public class InAirLogic : MonoBehaviour {
	private Collider2D lastCollider;
	public BaseSpriteStats stats;



	void Update() {
		Rigidbody2D rigid = stats.GetComponent<Rigidbody2D> ();

		if (lastCollider != null || Mathf.Abs(rigid.velocity.y) < .00001f) {
			stats.setInAir (false);
		} else {
			stats.setInAir(true);
		}

	}


	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.tag != stats.tag) {
			lastCollider = collider;
		}

	}

	void OnTriggerExit2D (Collider2D collider) {
		if (lastCollider == collider) {
			lastCollider = null;
		}
	}
}
