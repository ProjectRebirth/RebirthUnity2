using UnityEngine;
using System.Collections;

public enum GameState
{
	INTRO,MAIN_MENU, GAME, CREDITS
}

public class GameManager : MonoBehaviour
{
	public  GameState gameState { get; private set; }

	public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

	public static GameManager Instance {
		get {
			if (GameManager.instance == null) {
				DontDestroyOnLoad (GameManager.instance);
			}
			return GameManager.instance;
		}
	
	}
	//Awake is always called before any Start functions
	void Awake ()
	{
	}

	public void setGameState (GameState state)
	{
		this.gameState = state;
	}

	//Update is called every frame.
	void Update ()
	{
	}
}