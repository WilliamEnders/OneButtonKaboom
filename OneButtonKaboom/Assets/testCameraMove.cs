using UnityEngine;
using System.Collections;

public class testCameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			GetComponent<Animator>().Play("CameraMovement");
			GameObject.Find("UNIVERSE").GetComponent<spinAround>().spinSpeedX =+ 4;

		}
	
	}
}
