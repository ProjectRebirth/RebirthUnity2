using UnityEngine;
using System.Collections;

public class GraysonStats : BaseSpriteStats, IShooterStats, IClimbStats {

	public AssaultRifle assaultRifle;
	public BaseGunStats rifleStats;
	public float curShield;
	public float maxShield;
	public Vector2 strafeDirection;
	public float strafeSpeed;
	public float strafeCD;//CD stands for cool down!
	public ClimbMechanics climbMechanics;
	private float currentStrafeCD;

	protected virtual void Start() {
		strafeDirection = VectorLogic.normalizeVector2 (strafeDirection);
	}

	protected virtual void Update() {
		updateStrafeCoolDown ();
		if (curShield > maxShield) {
			curShield = maxShield;
		}
	}



	public bool getIsFiring() {
		return rifleStats.getIsFiring ();
	}
	public float getCurShield(){
		return curShield;
	}
	public float getMaxShield(){
		return maxShield;
	}
	public void takeDamage(float amt){
		if (curShield > 0) {
			float remainder = 0;
			if (amt > curShield) {
				remainder = amt - curShield;
				curShield = 0;
				curHealth -= remainder;
			}
			else{
				curShield -= amt;
			}
		} else {
			curHealth -= amt;
		}
		if (curHealth < 0) {
			curHealth = 0;
		}
	}

	private void updateStrafeCoolDown() {
		currentStrafeCD += Time.deltaTime;
		if (currentStrafeCD > strafeCD) {
			currentStrafeCD = strafeCD;
		}
	}

	public bool getIsClimbing() {
		return climbMechanics.getIsClimbing ();
	}

	public void resetStrafeCoolDown() {
		currentStrafeCD = 0f;
	}

	/// <summary>
	/// This is the ratio between the current strafe cool down and the max strafe cool down.
	/// </summary>
	/// <returns>The strafe CD ratio.</returns>
	public float getStrafeCDRatio() {
		return currentStrafeCD / strafeCD;
	}

	public float getCurrentStrafeCoolDown() {
		return currentStrafeCD;
	}

	public float getHealthRatio() {
		return curHealth / maxHealth;
	}

	public float getShieldRatio() {
		return curShield / maxShield;
	}

}
