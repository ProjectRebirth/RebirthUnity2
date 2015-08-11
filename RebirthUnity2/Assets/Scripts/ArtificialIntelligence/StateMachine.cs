using UnityEngine;
using System.Collections;

public abstract class StateMachine : MonoBehaviour {
	public BaseSpriteStats spriteStats;
	public State currentState;
	
	void Update() {
		updateCurrentState ();
	}

	void updateCurrentState() {
		currentState.updateState (Time.deltaTime);
	}

	void changeState(State newState) {
		currentState.exitState ();
		newState.enterState ();
		currentState = newState;
	}

	protected abstract void setDefaultState();
}

