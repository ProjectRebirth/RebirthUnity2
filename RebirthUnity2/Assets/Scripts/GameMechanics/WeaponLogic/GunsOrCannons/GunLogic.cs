using UnityEngine;
using System.Collections;

public abstract class GunLogic : MonoBehaviour {
	public Projectile projectile;//The bullet or other projectile that will be fired from the weapon
	public BaseSpriteStats weaponOwner;
	private float ammoRatio;//This is the ratio of ammo currently contained compared to the max ammo that can be held
	public int currentMagazine;
	public int maxMagazine;
	public float coolDown;//This is the interval of time between the time one bullet can be fired until the next
	public float spread;//The spread that a gun will have when firing its weapons\

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

	public bool getIsLookingUp() {
		return weaponOwner.getLastVerticalInput () > 0;
	}

	/// <summary>
	/// Quick way to check the percentage of ammo currently in the magazine to the maximum ammo the magazine can hold.
	/// </summary>
	/// <returns>The ammo ratio.</returns>
	public float getAmmoRatio() {
		return (float)currentMagazine / (float)maxMagazine;
	}


	public virtual void reload() {
		currentMagazine = maxMagazine;
	}
}
