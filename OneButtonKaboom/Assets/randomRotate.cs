using UnityEngine;
using System.Collections;

public class randomRotate : MonoBehaviour {

	// Use this for initializatin
	void Start () {
		transform.rotation = Random.rotation;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
