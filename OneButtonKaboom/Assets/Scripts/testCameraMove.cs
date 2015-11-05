using UnityEngine;
using System.Collections;

public class testCameraMove : MonoBehaviour {

	public bool addspin = false;
	private Vector3 cp;

	// Use this for initialization
	void Start () {
		GetComponent<Animator> ().enabled = false;
		cp = Camera.main.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("selector").GetComponent<ObjectsSelection> ().ready) {
			transform.position = new Vector3 (Random.Range(-3, 3)/400f+cp.x, Random.Range (-3, 3)/400f+cp.y, cp.z);
		}

		if (addspin){
			GameObject.Find("UNIVERSE").GetComponent<spinAround>().spinSpeedX += 0.2f;
			GameObject.Find ("UNIVERSE").GetComponent<Light> ().intensity -= 0.08f;
		}

		if(Input.GetKey(KeyCode.A)){

			Application.LoadLevel("Game");

		}
	
	}
}
