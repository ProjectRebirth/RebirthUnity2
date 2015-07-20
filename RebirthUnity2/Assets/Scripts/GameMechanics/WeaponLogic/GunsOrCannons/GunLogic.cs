using UnityEngine;
using System.Collections;

public abstract class GunLogic : MonoBehaviour {
	public Projectile projectile;//The bullet or other projectile that will be fired from the weapon
	public BaseSpriteStats weaponOwner;
	private float ammoRatio;//This is the ratio of ammo currently contained compared to the max ammo that can be held
	public int currentMagazine;
	public int maxMagazine;
	public float coolDown;//This is the interval of time between the time one bullet can be fired until the next
	public float spread;//The spread of the gun. A spread of one  means that the bullet has a chance of shooting at a 45 degree angle.

	private float coolDownTimer;


	protected virtual void Update() {
		updateCoolDownTimer();
	}


	private void updateCoolDownTimer() {
		coolDownTimer -= Time.deltaTime;
		if (coolDownTimer < 0f) {
			coolDownTimer = 0;
		}
	}

	public abstract void fireWeapon ();

	public virtual bool getIsLookingUp() {
		return weaponOwner.getLastVerticalInput () > 0;
	}

	/// <summary>
	/// Checks if the player is still shooting there gun. The default method of doing this is to check if the gun is completely cooled down.
	/// </summary>
	/// <returns><c>true</c>, if is firing was gotten, <c>false</c> otherwise.</returns>
	public virtual bool getIsFiring() {
		return coolDownTimer > 0f;
	}

	/// <summary>
	/// Quick way to check the percentage of ammo currently in the magazine to the maximum ammo the magazine can hold.
	/// </summary>
	/// <returns>The ammo ratio.</returns>
	public float getAmmoRatio() {
		return (float)currentMagazine / (float)maxMagazine;
	}

	/// <summary>
	/// Gets the cool down timer....derp
	/// </summary>
	/// <returns>The cool down timer.</returns>
	public float getCoolDownTimer() {
		return coolDownTimer;
	}

	public virtual void reload() {
		currentMagazine = maxMagazine;
	}
}
