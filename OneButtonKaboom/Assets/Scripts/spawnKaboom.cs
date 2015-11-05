using UnityEngine;
using System.Collections;

public class spawnKaboom : MonoBehaviour {

	public GameObject kaboom;
	private Transform whiteball;

	void Start(){
		whiteball = GameObject.Find ("UNIVERSE").transform;
	}

	// Use this for initialization
	public void startKaboom () {
	
		GameObject kaboomthing = Instantiate (kaboom,new Vector3(transform.position.x,transform.position.y,-6),transform.rotation) as GameObject;
		kaboomthing.transform.parent = transform;

	}

	public void startTurnOff(){

		whiteball.GetComponent<turnMeOff> ().TurnMeOff ();
	}
}
