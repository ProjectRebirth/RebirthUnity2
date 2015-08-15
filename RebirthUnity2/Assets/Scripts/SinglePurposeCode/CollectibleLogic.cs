using UnityEngine;
using System.Collections;

public class CollectibleLogic : MonoBehaviour {
	void OnTriggerEnter2D (Collider2D collider) {
		Destroy (this.gameObject);
	}
}
