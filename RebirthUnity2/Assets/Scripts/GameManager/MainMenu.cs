﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	GameManager GM;
	public Font tech;
	
	void Awake () {
		GM = gameObject.AddComponent<GameManager>();
	}
	
	void Start(){
		GM.setGameState(GameState.MAIN_MENU);
	}
	
	public void OnGUI(){
		//menu layout
		GUI.BeginGroup (new Rect (Screen.width / 2 - 145 , Screen.height / 2 - 150, 340, 800));
		GUI.backgroundColor = Color.white;
		GUI.skin.font = tech;
		if (GUI.Button (new Rect (0, 0, 290, 60), "New Game")){
			NewGame();
		}
		if (GUI.Button (new Rect (0,80, 290, 60), "Load Game")){
			LoadGame();
		}
		if (GUI.Button (new Rect (0,160, 290, 60), "Credits")){
			ShowCredits();
		}
		if (GUI.Button (new Rect (0,240 , 290, 60), "Quit")){
			Quit();
		}
		GUI.EndGroup();
	}
	
	
	
	
	public void NewGame(){
		GM.setGameState(GameState.GAME);
		Application.LoadLevel ("Level_01");
	}
	
	public void LoadGame(){
		//GM.SetGameState(GameState.CREDITS);
		//Application.LoadLevel ("");
	}
	public void ShowCredits(){
		GM.setGameState(GameState.CREDITS);
		Application.LoadLevel ("Credits");
	}
	
	public void Quit(){
		Debug.Log("Quit!");
		Application.Quit();
	}
}
