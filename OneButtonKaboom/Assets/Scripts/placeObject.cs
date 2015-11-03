using UnityEngine;
using System.Collections;

public class placeObject : MonoBehaviour {

	private Transform planet;
	public float offEarth;

	// Update is called once per frame
	public void placeMe () {
		planet = GameObject.FindGameObjectWithTag ("Planet").transform;
		transform.position = new Vector3 (planet.position.x,planet.position.y+(planet.localScale.y / 2)+offEarth+(transform.localScale.y),planet.position.z);
		transform.parent.gameObject.transform.rotation = Random.rotation;
	}
}
