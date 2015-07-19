using UnityEngine;
using System.Collections;

public class GunLogic : MonoBehaviour {
	public Projectile projectile;//The bullet or other projectile that will be fired from the weapon
	public BaseMechanics weaponOwner;
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

	public void fireProjectile() {

	}

	public float getAmmoRatio() {
		return (float)currentMagazine / (float)maxMagazine;
	}
}
