using UnityEngine;
using System.Collections;

public class ProjectileStats : MonoBehaviour {
	public float speed;
	public float rawDamage;
	public float destroyTime;
	public float bulletRange;//The distance that the bullet can travel before automatically being destroyed.
	public string enemyTag;
	private float destroyTimer;
	private bool hasCollided;
	private Vector2 direction;//Direction should always be a unit Vector
	private Vector3 originalPosition;
	private BaseGunStats weaponOrigin;// The weapon that the projectile was fired from.


	protected virtual void Start() {
		//direction = new Vector2 (1, 0);//The default direction of the projectile will be straight to the right
		destroyTimer = destroyTime;
		originalPosition = transform.position;
	}

	protected virtual void Update() {
		outOfRangeDestroy ();
		calculateDestroyTimer ();
	}

	private void calculateDestroyTimer() {
		if (hasCollided) {
			destroyTimer -= Time.deltaTime;
			if (destroyTimer < 0) {
				destroyTimer = 0;
			}
		} else {
			destroyTimer = destroyTime;
		}
	}

	public bool getDestroyBullet() {
		return destroyTimer <= 0;
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

	public void setWeaponOrigin(BaseGunStats weapon) {
		this.weaponOrigin = weapon;
	}

	public BaseGunStats getWeaponOrigin() {
		return weaponOrigin;
	}

	public bool getHasCollided() {
		return hasCollided;
	}

	public void setHasCollided(bool hasCollided) {
		this.hasCollided = hasCollided;
	}
}

