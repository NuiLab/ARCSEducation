using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB_LogicalTable : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject VButtonObject;
	private GameObject table;

	void Awake () {
		
	}

	// Use this for initialization
	void Start () {
		VButtonObject = GameObject.Find ("ReferenceButton");
		table = GameObject.Find ("LogicTable");

		VButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		table.GetComponent<Renderer> ().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		
		Debug.Log ("Button down");
		table.GetComponent<Renderer> ().enabled = true;
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Button up");
		table.GetComponent<Renderer> ().enabled = false;
	}
}
