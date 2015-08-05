using UnityEngine;
using System.Collections;

public class InAirLogic : MonoBehaviour {
	private Collider2D lastCollider;
	public BaseSpriteStats stats;



	void Update() {
		if (lastCollider != null) {
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
