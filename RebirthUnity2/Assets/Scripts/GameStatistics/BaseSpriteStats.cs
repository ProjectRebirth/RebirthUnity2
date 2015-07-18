using UnityEngine;
using System.Collections;

public class BaseSpriteStats : MonoBehaviour{
	public float maxHealth;//The maximum health that the sprite can hold at any given time
	public float curHealth;//The current health that the sprite has at any given time
	public float horizontalSpeed;
	public float horizontalMomentum;
	public float jumpSpeed;//The speed that will be immediately set to the y velocity
	public bool isRight;
	private bool inAir;
	private bool isWalking;
	

	public bool getInAir() {
		return inAir;
	}

	public virtual void setInAir(bool inAir) {
		this.inAir = inAir;
	}

	public bool getIsWalking() {
		return isWalking;
	}

	public virtual void setIsWalking(bool isWalking) {
		this.isWalking = isWalking;
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

}


