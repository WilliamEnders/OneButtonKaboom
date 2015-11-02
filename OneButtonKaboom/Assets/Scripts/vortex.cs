using UnityEngine;
using System.Collections;

public class vortex : MonoBehaviour {

	// Use this for initialization
	void Start () {
		theSelector = GameObject.Find ("selector").GetComponent<ObjectsSelection> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private ObjectsSelection theSelector; 
	private GameObject selectedObject;
	private Vector3 selectedObjectPos;
	private void OnCollisionEnter(Collision collision) {
		selectedObject = collision.gameObject;
		int _type = selectedObject.GetComponent<item> ().type;
		if(theSelector.hasType(_type)) {
			theSelector.getItemByType(_type).moveBack(); 
		}

		selectedObject.GetComponent<item>().moveAway(); 
		theSelector.select(selectedObject.GetComponent<item>().type,selectedObject.GetComponent<item>().id,selectedObject.GetComponent<item>());

		//Debug.Log(selectedObject.name+" "+selectedObject.GetComponent<item>().type+" "+selectedObject.GetComponent<item>().id,selectedObject.GetComponent<item>);
	}
}
