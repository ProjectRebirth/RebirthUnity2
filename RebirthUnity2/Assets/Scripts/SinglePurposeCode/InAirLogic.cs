using UnityEngine;
using System.Collections;

public class InAirLogic : MonoBehaviour {
	private int totalPlatformsEntered;
	public BaseSpriteStats stats;



	void Update() {
		if (totalPlatformsEntered > 0) {
			stats.setInAir (false);
		} else {
			stats.setInAir(true);
		}
	}


	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.tag != stats.tag) {
			totalPlatformsEntered++;
		}

	}

	void OnTriggerExit2D (Collider2D collider) {
		if (collider.tag != stats.tag) {
			totalPlatformsEntered--;
		}
	}
}
