using UnityEngine;
using System.Collections;

public abstract class ProjectileMechanics: MonoBehaviour {
	/// <summary>
	/// This method should be used to inflict damage upon whatever it collided with as well as add any logic
	/// related to the the impacet. For example a bomb would add an area of effect that can cause damage.
	/// </summary>
	public abstract void destroyProjectile();

}
