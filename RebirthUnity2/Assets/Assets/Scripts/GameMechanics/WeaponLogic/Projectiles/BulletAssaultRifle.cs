using UnityEngine;
using System.Collections;

public class BulletAssaultRifle : ProjectileMechanics {

	// Use this for initialization
	protected override void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	protected override void FixedUpdate() {
		base.FixedUpdate ();
		BoxCollider2D collider = GetComponent<BoxCollider2D> ();
		collider.enabled = !projectileStats.getHasCollided ();
		if (projectileStats.getHasCollided ()) {
			Rigidbody2D rigid = GetComponent<Rigidbody2D>();
			rigid.velocity = new Vector2(0, 0);

		}


	}

	void Update() {
		if (projectileStats.getDestroyBullet ()) {
			Destroy (this.gameObject);
		}
	}

	public override bool checkProjectileCollide(Collider2D collider) {
		return projectileStats.getWeaponOrigin().tag != collider.tag;
	}

	public void cancelHasCollided() {
		projectileStats.setHasCollided (false);
	}

	protected override void OnTriggerEnter2D(Collider2D collider) {
		if (checkProjectileCollide (collider)) {
			projectileStats.setHasCollided(true);
		}
	}
}
