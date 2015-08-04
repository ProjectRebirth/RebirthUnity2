﻿using UnityEngine;
using System.Collections;

public class BatMechanics : BaseMechanics {
	private BatStats batStats;

	protected override void Start() {
		base.Start ();
		batStats = (BatStats)baseStats;
	}

	protected override void Update() {
		checkSetDestroyTimer ();
		base.Update ();
	}

	/// <summary>
	///Updates the flight direction of the 
	/// </summary>
	protected override void FixedUpdate() {
		updateFlightDirection ();
	}

	private void updateFlightDirection() {
		Rigidbody2D rigid = GetComponent<Rigidbody2D> ();
		Vector2 currentUnit = rigid.velocity;
		Vector2 goalUnit = VectorLogic.normalizeVector2 (batStats.getLastHorizontalInput(), batStats.getLastVerticalInput()) * batStats.getSpeed();
		float x = Mathf.MoveTowards (currentUnit.x, goalUnit.x, Time.deltaTime * batStats.getHorizontalMomentum ());
		float y = Mathf.MoveTowards (currentUnit.y, goalUnit.y, Time.deltaTime * batStats.getVerticalMomentum ());
		rigid.velocity = new Vector2 (x, y);

	}

	private void checkSetDestroyTimer() {
		if (batStats.getIsDead() && Mathf.Abs(batStats.getVerticalSpeed()) < .00001f) {
			setTimer(true);
		}
	}

	public override void isDeadCleanUp() {
		if (baseStats.getIsDead ()) {
			Rigidbody2D rigid = GetComponent<Rigidbody2D>();
			rigid.gravityScale = 1;
		}
	}

}
