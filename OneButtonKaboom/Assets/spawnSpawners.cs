using UnityEngine;
using System.Collections;

public class spawnSpawners : MonoBehaviour {
	public GameObject[] a;
	public void Spawn(GameObject[] a){
		for(int i = 0;i<a.Length;i++){
			GameObject justSpawned = Instantiate(a[i],transform.position,transform.rotation) as GameObject;
			justSpawned.transform.parent = transform;
			
		}
	}
	// Update is called once per frame
	void Start () {

		Spawn (a);
	
	}
}
