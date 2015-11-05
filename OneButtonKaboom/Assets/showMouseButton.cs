using UnityEngine;
using System.Collections;

public class showMouseButton : MonoBehaviour {

	private GameObject selector;

	// Use this for initialization
	void Start () {

		selector = GameObject.Find("selector");
	
	}
	
	// Update is called once per frame
	void Update () {
		if (selector.GetComponent<ObjectsSelection> ().ready) {
			GetComponent<SpriteRenderer>().enabled = true;
		}
	
	}
}
