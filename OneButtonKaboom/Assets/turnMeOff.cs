using UnityEngine;
using System.Collections;

public class turnMeOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void TurnMeOff () {

		gameObject.SetActive (false);
	
	}
	public void TurnMeOn () {
		
		gameObject.SetActive (true);
		
	}
}
