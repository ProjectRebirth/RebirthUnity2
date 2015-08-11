using UnityEngine;
using System.Collections;

public interface IClimbMechanics {
	void climbObject();
	void detatchClimb();
}


public interface IClimbStats {
	bool getIsClimbing();

}
