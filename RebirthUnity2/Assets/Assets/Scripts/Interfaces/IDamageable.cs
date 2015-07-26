using UnityEngine;
using System.Collections;

/// <summary>
/// Anything that can lose health or take damage should implement this interface
/// </summary>
public interface IDamageable<T> {
	void takeDamage(T damagingObject);
}

/// <summary>
/// An Object that can die should implement this interface.
/// </summary>
public interface IKillable {
	void handleDeath();
}