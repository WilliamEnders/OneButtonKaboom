using UnityEngine;
using System.Collections;

public class planetSizer : MonoBehaviour {

	public float radius;

	// Use this for initialization
	void Start () {

		radius = Random.Range (5,7);
	
	}

	void Update(){
		transform.localScale = new Vector3 (radius, radius, radius);
	}

}
