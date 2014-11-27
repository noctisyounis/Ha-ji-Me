using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {
	public GameObject gameSettingsUI;
	public UISprite[] roundSprites = new UISprite[5];

	public void ChangeGUIRounds(string name){
		if (name=="roundPlus" && !roundSprites[4].enabled){
			GameManager.instance.AddRound();
			roundSprites[GameManager.instance.gameSettings.numberOfRounds-1].enabled = true;
		}
		if (name=="roundMin" && GameManager.instance.gameSettings.numberOfRounds > 1){
			GameManager.instance.RemoveRound();
			roundSprites[GameManager.instance.gameSettings.numberOfRounds].enabled = false;
		}
	}

	public void OnGameSettingsValidated(){
		gameSettingsUI.GetComponent<TweenAlpha>().enabled = true;
	}

	public void LaunchIntro(){
		StartCoroutine("Intro");
	}

	IEnumerator Intro(){
		// Effet sonore + landscape
		yield return new WaitForSeconds(5);

	}

	public void BuildInGameGUI(){

	}
}
