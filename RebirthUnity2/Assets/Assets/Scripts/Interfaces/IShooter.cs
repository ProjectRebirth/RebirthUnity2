using UnityEngine;
using System.Collections;

public interface IShooter {
	void fireWeapon(bool fireButtonDown);
	bool getIsFiring();
	bool checkCanFire();
	void reloadMain(bool reloadButtonDown);
}

