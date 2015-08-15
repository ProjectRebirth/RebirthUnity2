using UnityEngine;
using System.Collections;

public class HoverScript : MonoBehaviour {
	float timer;
	Vector3 originalPosition;
	public float intensity;
	public float speed;

	void Start() {
		originalPosition = transform.position;
	}

	void Update() {
		timer += Time.deltaTime;
		if (timer > 1000) {
			timer -= 1000;
		}

		Vector3 deltaPosition = new Vector3 (0, intensity, 0) * Mathf.Sin (speed * timer);
		transform.position = originalPosition + deltaPosition;

	}
}
