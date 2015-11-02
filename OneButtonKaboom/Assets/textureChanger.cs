using UnityEngine;
using System.Collections;

public class textureChanger : MonoBehaviour {

	public Material[] materials;
	int currentMat = 0;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material = materials[currentMat];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
