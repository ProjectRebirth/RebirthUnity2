﻿using UnityEngine;
using System.Collections;

public class BulletAssaultRifle : ProjectileMechanics {

	// Use this for initialization
	protected override void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override bool checkProjectileCollide(Collider2D collider) {
		return false;
	}

	public override void addBulletEffects() {
		GameObject effects = (GameObject)Instantiate (this.bulletEffects, transform.position, transform.rotation);
		effects.transform.parent = this.transform;

	}
}
