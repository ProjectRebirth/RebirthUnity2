﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Anything that relates to vector logic should go here. All or atleast most functions here should be static methods.
/// It is fine to have helper methods though.
/// </summary>
public class VectorLogic {
	public static Vector2 normalizeVector2(Vector2 vec) {
		float x = vec.x;
		float y = vec.y;
		float mag = getMagnitude2 (vec);
		if (mag == 0f) {
			return new Vector2();
		}
		return new Vector2 (x / mag, y / mag);
	}

	public static Vector2 normalizeVector2(float x, float y) {
		return normalizeVector2 (new Vector2 (x, y));
	}
	
	public static float getMagnitude2(Vector2 vec) {
		float x = vec.x;
		float y = vec.y;

		return Mathf.Sqrt (x * x + y * y);
	}

}
