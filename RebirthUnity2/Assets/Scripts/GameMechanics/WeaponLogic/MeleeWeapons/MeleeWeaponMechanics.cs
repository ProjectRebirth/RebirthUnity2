using UnityEngine;
using System.Collections;

public class MeleeWeaponMechanics : MonoBehaviour {
	public MeleeWeaponStats meleeStats;	


	protected virtual void Update() {
		if (!meleeStats.getIsAttacking ()) {
			meleeStats.resetCollidedList();
		}
	}


	public void attack() {
		if (checkCanAttack ()) {
			meleeStats.resetAttackTimer();
			meleeStats.resetCoolDownTimer();
		}
	}
		
	
	protected virtual bool checkCanAttack() {
		return !meleeStats.getIsAttacking() && meleeStats.getIsCooledDown();
	}

	protected virtual void OnTriggerEnter2D(Collider2D collider) {
		BaseMechanics enemyStats = collider.GetComponent<BaseMechanics> ();
		if (collider.tag == meleeStats.enemyTag) {
			if (meleeStats.checkObjectCollided(collider.gameObject)) {
				enemyStats.takeDamage(meleeStats.rawDamage, this.GetComponent<Collider2D>());
			}

			meleeStats.addCollidedObject(collider.gameObject);
		}
	}
}
