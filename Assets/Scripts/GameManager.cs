using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public enum STATE {gameSetup, ha,ji,me};
	public static STATE currentState;
	public static GameManager instance;
	public GameSettings gameSettings;

	void Awake(){
		instance = this;
	}

	// Use this for initialization
	void Start () {
		currentState = STATE.gameSetup;
		gameSettings = new GameSettings();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTap(Gesture gesture){
		if (currentState == STATE.gameSetup)return;
	}

	public void AddRound(){
		gameSettings.numberOfRounds++;
	}

	public void RemoveRound(){
		gameSettings.numberOfRounds--;
	}

	public void BuildGameSettings(){
	}
}
