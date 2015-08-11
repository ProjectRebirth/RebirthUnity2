using UnityEngine;
using System.Collections;

public abstract class State {
	public StateMachine stateMachine;

	public abstract void updateState(float deltaTime);
	public abstract void enterState();
	public abstract void exitState();

	/// <summary>
	/// This method will be called when some object has a entered a line of sight.
	/// </summary>
	/// <param name="collider">Collider.</param>
	public virtual void handleOnTriggerEnter(Collider2D collider) {

	}

	/// <summary>
	/// This method will be used to handle the instance where an object has exitted a line of sight
	/// </summary>
	/// <param name="collider">Collider.</param>
	public virtual void handleOnTriggerExit(Collider2D collider) {

	}

}
