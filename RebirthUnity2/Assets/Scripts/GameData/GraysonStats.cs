using UnityEngine;
using System.Collections;

public class GraysonStats : BaseSpriteStats, IShooterStats {

	public AssaultRifle assaultRifle;
	public BaseGunStats rifleStats;
	public float curShield;
	public float maxShield;

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
}
