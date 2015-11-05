using UnityEngine;
using System.Collections;

public class textureChanger : MonoBehaviour {

	public Material[] materials;

	// Use this for initialization
	void Start () {
	}
	public void changeTexture(int currentMat){
		GetComponent<Renderer>().material = materials[currentMat];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
