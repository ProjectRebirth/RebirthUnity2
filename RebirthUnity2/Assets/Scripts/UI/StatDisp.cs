﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatDisp : MonoBehaviour {
	public GraysonStats graysonStats;
	public BaseGunStats weapStats;
	public GraysonMechanics cooldownMech;
	
	public Image healthBar;
	public Image damageBar;
	
	public Image shieldBar;
	public Image impactBar;
	
	public Image shieldBar2;
	public Image impactBar2;
	
	public Image ammoTint0;
	public Image ammoTint1;
	public Image ammoTint2;
	public Image ammoTint3;
	
	public Image energyBar;
	
	public float initHealth;
	public float initShield;
	
	public int currentAmmo;
	
	public Font tech;

	// Use this for initialization
	void Start () {
		initHealth = graysonStats.getCurHealth ();
		initShield = graysonStats.getCurShield ();
	}
	
	// Update is called once per frame
	void Update () {
		updateAmmo ();
		updateHPShield ();
		updateEnergy ();
		if (Input.GetKeyDown (KeyCode.O)) {
			graysonStats.takeDamage(11f);
		}
		
	}
	
	void updateAmmo(){
		
		if (currentAmmo > 30) {
			ammoTint3.fillAmount = (1f - ((currentAmmo - 30) / 10f));
			ammoTint2.fillAmount = 0;
			ammoTint1.fillAmount = 0;
			ammoTint0.fillAmount = 0;
			
		} else if (currentAmmo <= 30 && currentAmmo > 20) {
			ammoTint3.fillAmount = 1f;
			ammoTint2.fillAmount = (1f - ((currentAmmo - 20) / 10f));
			ammoTint1.fillAmount = 0;
			ammoTint0.fillAmount = 0;
		} else if (currentAmmo <= 20 && currentAmmo > 10) {
			ammoTint3.fillAmount = 1f;
			ammoTint2.fillAmount = 1f;
			ammoTint1.fillAmount = (1f - ((currentAmmo - 10) / 10f));
			ammoTint0.fillAmount = 0;
		} else if (currentAmmo <= 10 && currentAmmo > 0) {
			ammoTint3.fillAmount = 1f;
			ammoTint2.fillAmount = 1f;
			ammoTint1.fillAmount = 1f;
			ammoTint0.fillAmount = (1f - (currentAmmo / 10f));
		} else {
			ammoTint3.fillAmount = 1f;
			ammoTint2.fillAmount = 1f;
			ammoTint1.fillAmount = 1f;
			ammoTint0.fillAmount = 1f;
		}
		
		currentAmmo = weapStats.getCurrentMagazine();
		
	}
	void updateHPShield(){
	
		//float s2Frac = (graysonStats.getCurShield () - (graysonStats.getMaxShield ()/2f)) / (graysonStats.getMaxShield ()/2) ;
		float s1Frac = (graysonStats.getCurShield () / (graysonStats.getMaxShield ()/2f) );
		float hpFrac = (graysonStats.getCurHealth () / graysonStats.getMaxHealth ());
		//float initS2Frac = ((initShield - (graysonStats.getMaxShield ()/2f)) / (graysonStats.getMaxShield ()/2));
		float initS1Frac = (initShield / (graysonStats.getMaxShield () / 2));
		float initHPFrac = initHealth / (graysonStats.getMaxHealth ());
		
		if (initShield > graysonStats.getCurShield ()) {
			initShield -= Time.deltaTime *12f;
		} else {
			initShield = graysonStats.getCurShield ();
			
		}
		
		if (initHealth> graysonStats.getCurHealth ()) {
			initHealth -= Time.deltaTime *30f;
		} else {
			initHealth = graysonStats.getCurHealth ();
		}
		//float shield2Diff = Mathf.MoveTowards (((initShield - (graysonStats.getMaxShield ()/2f)) / (graysonStats.getMaxShield ()/2)), s2Frac / 2f, Time.deltaTime );
		float shield1Diff = Mathf.MoveTowards ((initShield  / (graysonStats.getMaxShield ()/2)), s1Frac / 2f, Time.deltaTime );
		float hpDiff = Mathf.MoveTowards (initHealth  / (graysonStats.getMaxHealth()), hpFrac / 2f, Time.deltaTime );
		
		if (graysonStats.getCurShield () > 50) {
			impactBar.fillAmount = .5f;
			//impactBar2.fillAmount = shield2Diff / 2f;
			//impactBar2.fillAmount = initS2Frac / 2f;
			shieldBar.fillAmount = .5f;
			//shieldBar2.fillAmount = s2Frac / 2f;
			
		} else if (graysonStats.getCurShield () <= 50 && graysonStats.getCurShield () > 0) {
			
			impactBar.fillAmount = shield1Diff / 2f;
			impactBar.fillAmount = initS1Frac/ 2f;
			//impactBar2.fillAmount = 0;
			shieldBar.fillAmount = s1Frac / 2f;
			//shieldBar2.fillAmount = 0;
		} else {
			shieldBar.fillAmount = 0;
			//shieldBar2.fillAmount = 0;
			impactBar.fillAmount = 0;
			//impactBar2.fillAmount = 0;
		}
		
		healthBar.fillAmount = hpFrac / 2f;
		damageBar.fillAmount = initHPFrac / 2f;
		damageBar.fillAmount = hpDiff / 2f;
	}

	
	void updateEnergy(){
		//energyBar.fillAmount = ((cooldownMech.getCooldownTimer() * - 1f) + cooldownMech.getStrafeCD())/cooldownMech.getStrafeCD();
	}
}
