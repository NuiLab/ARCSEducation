using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicTable : MonoBehaviour {

	public GameObject table;
	// Use this for initialization
	void Start () {
		table = GameObject.Find ("LogicalOrTable");
		Debug.Log (table);
		Debug.Log ("Should have loaded the empty instance");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
