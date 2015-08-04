using UnityEngine;
using System.Collections;

public interface IShooter {
	void fireWeapon(bool fireButtonDown);
	bool checkCanFire();
	void reloadMain(bool reloadButtonDown);
}

