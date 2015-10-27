using UnityEngine;
using System.Collections;

public class spawnSpawners : MonoBehaviour {

	public GameObject[] toSpawn;

	// Use this for initialization
	void Start () {

		for(int i = 0;i<toSpawn.Length;i++){
			GameObject justSpawned = Instantiate(toSpawn[i],transform.position,transform.rotation) as GameObject;
			justSpawned.transform.parent = transform;
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
