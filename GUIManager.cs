using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {
	
	private static GUIManager instance;
	
	public GameObject instructionsPanel;
	public Text distanceText,instructionsText, boostsText,runnerText,gameOverText;
	
	void Start () {
		instance = this;
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
	}

	void Update () {
		if(Input.GetButtonDown("Jump")){
			GameEventManager.TriggerGameStart();
		}
	}
	
	private void GameStart () {
		instance.runnerText.text = "";
		instance.instructionsText.text = "";
		instance.gameOverText.text = "";
//		instructionsPanel.setActive(false);
		enabled = false;
	}
	
	private void GameOver () {
		instance.gameOverText.text = "Game Over";
		instance.instructionsText.text = "Press spacebar to restart.";
		enabled = true;
	}
	
	public static void SetBoosts(int boosts){
		instance.boostsText.text = "Available Boosts: "+boosts.ToString();
	}

	public static void SetDistance(float distance){
		instance.distanceText.text = "Distance Run: "+distance.ToString("f0");
	}
}
