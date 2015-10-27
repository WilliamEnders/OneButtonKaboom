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
	private GameObject[]spawningItems;
	public GameObject[][] itemsTable;
	public GameObject[] itemsTable1;
	public GameObject[] itemsTable2;
	public GameObject[] itemsTable3;
	public GameObject[] itemsTable4;
	private const int itemsMaxNum =  4;
	private const int selectedItemsMaxNum = 4;
	
	private void init(){
		items1 = new int[]{1,2,3,4};
		items2 = new int[]{5,6,7,8};
		items3 = new int[]{9,10,11,12};
		items4 = new int[]{13,14,15,16};
		
		selectedItems = new int[]{0,0,0,0};

		itemsTable = new GameObject[4] [4];

		for(int i =1; i <4; i++){
			itemsTable[i-1]=this["itemsTable"+i];
		}
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
		
	}
	
	
}