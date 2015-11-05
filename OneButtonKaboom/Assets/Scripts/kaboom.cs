using UnityEngine;
using System.Collections;

public class kaboom : MonoBehaviour {

	private Transform camera;
	private Transform mousebutton;
	private MeshRenderer wall;
	private int time;
	private bool ready;

	// Use this for initialization
	void Start () {
		camera = GameObject.Find ("Main Camera").transform;
		mousebutton = GameObject.Find ("mouse-01").transform;
		wall = GameObject.Find ("WALL").GetComponent<MeshRenderer>();
		time = 0;
		ready = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(ready){
		if(time == 50){
			wall.enabled = true;
				ready = false;
			
		}else{
			time++;
		}
		}
	}

	private void OnMouseDown()
	{
		if (GameObject.Find ("selector").GetComponent<ObjectsSelection> ().ready) {
			Debug.Log ("k");
			GameObject.Find ("selector").GetComponent<ObjectsSelection> ().kaboom ();
			mousebutton.gameObject.SetActive(false);
			camera.GetComponent<Animator> ().enabled = true;
			camera.GetComponent<Animator> ().Play ("CameraMovement");
			camera.GetComponent<testCameraMove> ().addspin = true;
			ready = true;
		}
	}
}
