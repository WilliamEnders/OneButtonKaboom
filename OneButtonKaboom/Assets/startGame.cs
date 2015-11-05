using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {

	// Use this for initialization
	public void startIntroButton () {
		Application.LoadLevel("Intro");
		
	}


	public void startGameButton () {
		Application.LoadLevel("Game");
	
	}

	public void startCreditsButton () {
		Application.LoadLevel("Credits");
		
	}
}
