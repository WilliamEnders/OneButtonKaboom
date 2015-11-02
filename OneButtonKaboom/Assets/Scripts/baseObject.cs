using UnityEngine;
using System.Collections;

public class baseObject : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//--------------public---------------
	public int type;
	public int id; 
	public void moveBack(){
		transform.position = originalPos;
		transform.rotation = new Quaternion ();
		gameObject.GetComponent<Rigidbody> ().useGravity = true;
	}
	public void moveAway(){
		transform.position = new Vector3 (500, 500, 500);
		gameObject.GetComponent<Rigidbody> ().useGravity = false;

	}
	//--------------private-----------------
	private Vector3 originalPos = new Vector3(0,0,0);
	private Vector3 screenPoint;
	private Vector3 offset;
	private bool grub =false;
	private void OnMouseDown()
	{
		if (originalPos == new Vector3(0,0,0)) {
			originalPos = transform.position;
		}
		grub = true;
		screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		offset = transform.position - Camera.main.ScreenToWorldPoint(
			new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		GetComponent<Rigidbody> ().freezeRotation = true;
		GetComponent<Rigidbody> ().useGravity = false;
		GetComponent<BoxCollider> ().enabled = false;
	}
	private void OnMouseDrag() {
		if (grub) {
			Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
			transform.position = curPosition;
		}
	}
	private void OnMouseUp(){
		if (grub) {
			GetComponent<Rigidbody> ().useGravity = true;
			GetComponent<Rigidbody> ().freezeRotation = false;
			GetComponent<BoxCollider> ().enabled = true;
			grub=false;
		}
	}
}
