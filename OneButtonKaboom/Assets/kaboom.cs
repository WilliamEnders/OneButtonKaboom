﻿using UnityEngine;
using System.Collections;

public class kaboom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnMouseDown()
	{
		Debug.Log ("k");
		GameObject.Find ("selector").GetComponent<ObjectsSelection> ().kaboom ();
	}
}
