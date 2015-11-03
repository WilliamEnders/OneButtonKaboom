using UnityEngine;
using System.Collections;

public class testCameraMove : MonoBehaviour {

	private bool addspin = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			GetComponent<Animator>().Play("CameraMovement");
			addspin = true;

		}

		if (addspin){
			GameObject.Find("UNIVERSE").GetComponent<spinAround>().spinSpeedX += 0.2f;
		}
	
	}
}
