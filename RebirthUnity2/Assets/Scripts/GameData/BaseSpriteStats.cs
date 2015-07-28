using UnityEngine;
using System.Collections;


/// <summary>
/// This class simply holds the statisitcs and current state of the object that it is attatched to. This class does not carry out any actions on its own.
/// Every object that uses this class NEEDS a Mechanics class attatched to it. Mechanics classes uses and manipulate stats classes.
/// </summary>

public class BaseSpriteStats : MonoBehaviour{
	public float maxHealth;//The maximum health that the sprite can hold at any given time
	public float curHealth;//The current health that the sprite has at any given time
	public float horizontalSpeed;
	public float horizontalMomentum;
	public float jumpSpeed;//The speed that will be immediately set to the y velocity
	public bool isRight;
	private bool inAir;
	private float lastHorInput;
	private float lastVertInput;
		

	public bool getInAir() {
		return inAir;
	}

	public virtual void setInAir(bool inAir) {
		this.inAir = inAir;
	}

	public bool getIsWalking() {
		return Mathf.Abs(GetComponent<Rigidbody2D> ().velocity.x) > 0.01f;
	}

	public float getSpeed() {
		return horizontalSpeed;
	}

	public float getHorizontalMomentum() {
		return horizontalMomentum;
	}


	public bool getIsRight() {
		return isRight;
	}

	public void setIsRight(bool isRight) {
		this.isRight = isRight;
	}

	public float getLastHorizontalInput() {
		return lastHorInput;
	}

	public void setLastHorizontalInput(float horInput) {
		this.lastHorInput = horInput;
	}

	public float getLastVerticalInput() {
		return lastVertInput;
	}

	public void setLastVerticalInput(float vertInput) {
		this.lastVertInput = vertInput;
	}

	public bool getIsLookingUp() {
		return lastVertInput > 0;
	}




}


