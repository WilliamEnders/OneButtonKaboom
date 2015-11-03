using UnityEngine;
using System.Collections;

public class hell : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter(Collision collision) {
		GameObject selectedObject = collision.gameObject;
		selectedObject.GetComponent<item>().moveBack(); 
	}
}
