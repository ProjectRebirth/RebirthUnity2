using UnityEngine;
using System.Collections;

public class BatProjectileMechanics : ProjectileMechanics {


	protected override void Start() {

	}

	public override bool checkProjectileCollide(Collider2D collider) {
		return false;
	}
}
