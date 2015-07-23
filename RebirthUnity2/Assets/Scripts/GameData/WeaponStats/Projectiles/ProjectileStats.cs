using UnityEngine;
using System.Collections;

public class ProjectileStats : MonoBehaviour {
	public float speed;
	public float rawDamage;
	private Vector2 direction;//Direction should always be a unit Vector
	private Vector3 originalPosition;

	protected virtual void Start() {
		//direction = new Vector2 (1, 0);//The default direction of the projectile will be straight to the right
		originalPosition = transform.position;
	}

	protected virtual void Update() {
		outOfRangeDestroy ();
	}


	private void outOfRangeDestroy() {
		Vector2 originalP = new Vector2 (originalPosition.x, originalPosition.y);
		Vector2 currentP = new Vector2 (transform.position.x, transform.position.y);
		if (VectorLogic.getMagnitude2 (originalP - currentP) > 10) {
			Destroy (this.gameObject);
		}
	}

	public Vector2 getDirection() {
		return direction;
	}

	public void setDirection(Vector2 vec) {
		this.direction = VectorLogic.normalizeVector2(vec);
		Vector3 angles = transform.eulerAngles;
		float x = angles.x;
		float y = angles.y;
		float z = Mathf.Atan2 (vec.y , vec.x) * Mathf.Rad2Deg;
		transform.eulerAngles = new Vector3 (x, y, z);
	}
}

