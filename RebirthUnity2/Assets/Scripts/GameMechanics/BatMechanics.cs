using UnityEngine;
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
