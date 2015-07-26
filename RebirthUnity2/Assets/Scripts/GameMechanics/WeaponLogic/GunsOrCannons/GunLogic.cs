using UnityEngine;
using System.Collections;

public abstract class GunLogic : MonoBehaviour {
	public BaseGunStats baseGunStats;


	protected virtual void Start() {

	}

	protected virtual void Update() {

	}




	public abstract void fireWeapon ();

	public abstract void reload ();
}
