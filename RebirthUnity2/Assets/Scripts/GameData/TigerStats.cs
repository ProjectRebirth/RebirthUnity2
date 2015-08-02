using UnityEngine;
using System.Collections;

public class TigerStats : BaseSpriteStats {
	private bool isAttacking;
	public float attackTime;
	private float attackTimer;


	public bool getIsAttacking() {
		return isAttacking;
	}

	public void setIsAttacking(bool isAttacking) {
		this.isAttacking = isAttacking;
	}


}
