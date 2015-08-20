using UnityEngine;
using System.Collections;


/**
 * Logic for the camera will go here. At the moment
 * you can move the camera a little offset from the player and zoom in
 * and out using the scaling variable.
 */ 
public class TempCamController : MonoBehaviour {
	public Transform followPlayer;//The character that we want to follow
	public float offsetX;//How far left or right from the character we want the camera
	public float offsetY;//How far up or down from the character we want the camera to be
	public float smoothing;

	private Vector3 offsetVector;
	
	/*
	 * Updates to follow the player on the screen
	 */
	void Update() {
		Vector3 targetVector = followPlayer.position + offsetVector;
		transform.position = Vector3.Lerp (transform.position, targetVector, smoothing * Time.deltaTime);

		
	}

	void Start() {
		Camera mainCamera = GetComponent<Camera> ();
		mainCamera.transparencySortMode = TransparencySortMode.Orthographic;
		offsetVector = new Vector3 (offsetX, offsetY, transform.position.z);
	}
}
