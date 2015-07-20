using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// </summary>
public abstract class ProjectileMechanics: MonoBehaviour {
	public ProjectileStats projectileStats;
	protected virtual void Start() {

	}

	protected virtual void FixedUpdate() {
		updateMovement ();
	}

	protected virtual void updateMovement () {
		Rigidbody2D rigid = GetComponent<Rigidbody2D> ();
		rigid.velocity = projectileStats.getDirection () * projectileStats.speed;
	}

	/// <summary>
	/// This method should be used to inflict damage upon whatever it collided with as well as add any logic
	/// related to the the impacet. For example a bomb would add an area of effect that can cause damage.
	/// </summary>
	public virtual void destroyProjectile() {
		Destroy (this.gameObject);
	}

	public abstract bool checkProjectileCollide (Collider2D collider);

	protected virtual void OnTriggerEnter2D(Collider2D collider) {
		if (checkProjectileCollide (collider)) {
			destroyProjectile ();
		}
	}
}
