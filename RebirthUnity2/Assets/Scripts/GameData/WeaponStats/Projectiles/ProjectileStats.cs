using UnityEngine;
using System.Collections;

public class ProjectileStats : MonoBehaviour {
	public float speed;
	public float rawDamage;
	private Vector2 direction;

	protected virtual void Start() {
		direction = new Vector2 (0, 1);//The default direction of the projectile will be straight to the right
	}

	protected virtual void Update() {
		updateMovement ();
	}


	protected virtual void updateMovement() {

	}


	public Vector2 getDirection() {
		return direction;
	}

	public void setDirection(Vector2 vec) {
		this.direction = vec;
	}
}
