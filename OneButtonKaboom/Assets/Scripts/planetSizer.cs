﻿using UnityEngine;
using System.Collections;

public class planetSizer : MonoBehaviour {

	public float radius;
	public float spinSpeedY;
	public float spinSpeedX;

	// Use this for initialization
	void Start () {

		radius = Random.Range (5,10);
	
	}

	void Update(){
		transform.localScale = new Vector3 (radius, radius, radius);

		transform.Rotate (new Vector3(0,spinSpeedY,spinSpeedX));
	}

}
