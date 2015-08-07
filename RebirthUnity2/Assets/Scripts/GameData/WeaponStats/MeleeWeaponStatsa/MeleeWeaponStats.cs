using UnityEngine;
using System.Collections;

public class MeleeWeaponStats : MonoBehaviour {
	public float coolDownTime;//The amount of time before the sprite can attack again
	private float coolDownTimer;
	public float attackTime;
	private float attackTimer;
	public float rawDamage;//The damage that will be given if the player has no shields or buffs
	public BaseSpriteStats owner;

	void Start() {
		IMeleeStats checkStats = owner as IMeleeStats;
		if (owner == null || checkStats == null) {
			print ("The owner of this weapon is not a melee type sprite");
		}
	}

	void Update() {
		updateAttackTimer ();
		updateCoolDownTimer ();
		
	}
	
	private void updateAttackTimer() {
		attackTimer -= Time.deltaTime;
		if (attackTimer < 0) {
			attackTimer = 0;
		}
	}
	
	private void updateCoolDownTimer() {
		if (!getIsAttacking ()) {
			coolDownTimer -= Time.deltaTime;
		}
		if (coolDownTimer < 0) {
			coolDownTimer = 0;
		}
	}
	
	public virtual bool getIsAttacking() {
		return attackTimer > 0;
	}
	
	public virtual bool getIsCooledDown() {
		return coolDownTimer <= 0;
	}
	
	public virtual void resetAttackTimer() {
		attackTimer = attackTime;
	}

	public virtual void resetCoolDownTimer() {
		coolDownTimer = coolDownTime;
	}

}
