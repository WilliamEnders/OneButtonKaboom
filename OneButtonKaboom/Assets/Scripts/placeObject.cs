using UnityEngine;
using System.Collections;

public class placeObject : MonoBehaviour {

	private Transform planet;
	public float offEarth;

	// Use this for initialization
	void Start () {
		planet = GameObject.FindGameObjectWithTag ("Planet").transform;
		transform.position = new Vector3 (0,0+(planet.localScale.y / 2)+offEarth+(transform.localScale.y),0);
		transform.parent.gameObject.transform.rotation = Random.rotation;
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
