using UnityEngine;
using System.Collections;

public class spinAround : MonoBehaviour {

	
	public float spinSpeedY;
	public float spinSpeedX;

	// Update is called once per frame
	void Update () {
		
		transform.Rotate (new Vector3(0,spinSpeedY,spinSpeedX));
	
	}
}
