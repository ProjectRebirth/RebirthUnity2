using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
	
	GameManager GM;
	
	void Awake () {
		GM = gameObject.AddComponent<GameManager>();
	}
	
	void Start () {
		GM.setGameState(GameState.INTRO);
		Invoke("LoadLevel", 3f);
	}
	
	public void LoadLevel(){
		Application.LoadLevel("MainMenu");
	}
}
