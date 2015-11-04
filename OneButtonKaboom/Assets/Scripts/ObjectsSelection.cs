using UnityEngine;
using System.Collections;

public class ObjectsSelection : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		init ();
	}
	
	// Update is called once per frame
	void Update () {


	}
	public GameObject[] itemsTable1;
	public GameObject[] itemsTable2;
	public GameObject[] itemsTable3;
	public GameObject[] itemsTable4;


	private int[] selectedType;
	private item[] selectedItems;
	private GameObject[]selectedSpawner;
	private int ground;
	public bool ready = false;
	private bool pumpkin = false; 
	//
	//
	//
	public void kaboom(){
		if (selectedType [0] * selectedType [1] * selectedType [2] * selectedType [3] != 0) {
			send (selectedSpawner);
		}
	}
	public void select(int _t, int _c, item _o){
		selectedItems [_t-1] = _o;
		if (_t == 1) {
			selectedSpawner [_t - 1] = itemsTable1 [_c-1];
		} else if (_t == 2) {
			pumpkin=(_c==4);
			selectedSpawner [_t - 1] = itemsTable2 [_c-1];
		} else if (_t == 3) {
			ground = _c-1;
			selectedSpawner [_t - 1] = itemsTable3 [_c-1];
		} else {
			selectedSpawner [_t - 1] = itemsTable4 [_c-1];
		}
		selectedType [_t-1] = 1;
		int _total = 0;
		for (int i=0;i<4;i++) {
			_total += selectedType [i];
			//Debug.Log (i+", " +selectedType[i] );
		}
		//Debug.Log (_total);
		GameObject.Find ("UNIVERSE").GetComponent<Light> ().range = 0.87f+ + _total * 0.15f;
		GameObject.Find ("UNIVERSE").GetComponent<Light> ().intensity = 0.65f+ + _total * 0.3f;
		GameObject.Find ("UNIVERSE").GetComponent<spinAround> ().spinSpeedX = 0.2f+ + _total * 0.5f;
		ready = (_total == 4);
		Debug.Log (ready);
	}
	public bool hasType(int _t){
		return selectedType [_t-1] == 1;
	}
	public item getItemByType(int _t){
		return selectedItems [_t-1];
	}
	//
	//
	//
	private void init(){


		selectedType = new int[]{0,0,0,0};

		selectedItems = new item[4];
		selectedSpawner = new GameObject[4];
	}

	private void send(GameObject[] a){
		spawnSpawners target = (spawnSpawners) GameObject.Find("Planet").GetComponent(typeof(spawnSpawners));
		target.Spawn (a,ground);
		if (pumpkin) {
			target.SpawnObj (itemsTable2 [4]);
		}
	}
	
	
}