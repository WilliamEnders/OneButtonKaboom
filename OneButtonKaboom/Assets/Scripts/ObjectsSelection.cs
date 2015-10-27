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
	public GameObject PumpkinSpawner;

	private int[] items1;
	private int[] items2;
	private int[] items3;
	private int[] items4;
	private int[] selectedItems;

	public GameObject[] itemsTable1;
	public GameObject[] itemsTable2;
	public GameObject[] itemsTable3;
	public GameObject[] itemsTable4;

	private GameObject[][] itemsTable;

	private void init(){
		items1 = new int[]{1,1,1,1};
		items2 = new int[]{2,2,2,2};
		items3 = new int[]{3,3,3,3};
		items4 = new int[]{4,4,4,4};
		
		selectedItems = new int[]{0,0,0,0};

		itemsTable [1] = itemsTable1;
		itemsTable [2] = itemsTable2;
		itemsTable [3] = itemsTable3;
		itemsTable [4] = itemsTable4;

	}
	private void select(int _t, int _c){
		selectedItems [_c] = _t;
	}
	private void selectEnd(){
		if(System.Array.IndexOf(selectedItems,0)>=0){
			kaboom ();
		}
	}
	private void kaboom(){
		foreach(int i in selectedItems){
			send(itemsTable[selectedItems[i]]);
		}
	}
	private void send(GameObject[] a){
		spawnSpawners target = (spawnSpawners) GameObject.Find("Planet").GetComponent(typeof(spawnSpawners));
		target.Spawn (a);
	}
	
	
}