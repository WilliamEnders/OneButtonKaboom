using UnityEngine;
using System.Collections;

public class spawnObjects : MonoBehaviour {

	public GameObject spawnObj;

	// Use this for initialization
	void Start () {

		for(int i = 0;i<10;i++){
			GameObject justSpawned = Instantiate(spawnObj,transform.position,transform.rotation) as GameObject;
			justSpawned.transform.parent = transform;

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
