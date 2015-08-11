using UnityEngine;
using System.Collections;

public class SkeletonProjectile : BulletAssaultRifle {

	protected override void OnTriggerEnter2D(Collider2D collider) {
		base.OnTriggerEnter2D (collider);

	}
}
