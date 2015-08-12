using UnityEngine;
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
		float delta = 0;
		float maxShield = graysonStats.getMaxShield ();

		float shieldFrac = graysonStats.getShieldRatio();
		float hpFrac = graysonStats.getHealthRatio();

		float initShieldFrac = initShield / graysonStats.getMaxShield ();
		float initHPFrac = initHealth / graysonStats.getMaxHealth ();

		float shield1Diff = Mathf.MoveTowards (initShieldFrac, shieldFrac / 2f, Time.deltaTime );
		float hpDiff = Mathf.MoveTowards (initHPFrac, hpFrac / 2f, Time.deltaTime );
		
		if (graysonStats.getCurShield () > 0) {
			impactBar.fillAmount = shield1Diff / 2f;
			shieldBar.fillAmount = shieldFrac / 2f;
		} else {
			shieldBar.fillAmount = 0;
			impactBar.fillAmount = 0;
		}

		if (maxShield >= 0 && maxShield <= 50) {
			delta = 12f;
			shieldBar.canvasRenderer.SetColor (new Color (.6f, .196f, .8f));
			impactBar.canvasRenderer.SetColor (Color.magenta);
		} else if (maxShield > 50 && maxShield <= 100) {
			delta = 18f;
			shieldBar.canvasRenderer.SetColor (Color.blue);
			impactBar.canvasRenderer.SetColor (Color.cyan);
		} else if (maxShield > 100 && maxShield <= 150) {
			delta = 27f;
			shieldBar.canvasRenderer.SetColor (new Color (0f, .502f, 0f));
			impactBar.canvasRenderer.SetColor (Color.green);
		} else if(maxShield > 150) {
			delta = 40f;
			shieldBar.canvasRenderer.SetColor (new Color(1, .647f, 0));
			impactBar.canvasRenderer.SetColor (Color.yellow);
		}

		if (initShield > graysonStats.getCurShield ()) {
			initShield -= Time.deltaTime * delta;
		} else {
			initShield = graysonStats.getCurShield ();
		}
		
		if (initHealth> graysonStats.getCurHealth ()) {
			initHealth -= Time.deltaTime *30f;
		} else {
			initHealth = graysonStats.getCurHealth ();
		}


		healthBar.fillAmount = hpFrac / 2f;
		damageBar.fillAmount = initHPFrac / 2f;
		damageBar.fillAmount = hpDiff / 2f;
	}

	
	void updateEnergy(){
		//energyBar.fillAmount = ((cooldownMech.getCooldownTimer() * - 1f) + cooldownMech.getStrafeCD())/cooldownMech.getStrafeCD();
	}
}
