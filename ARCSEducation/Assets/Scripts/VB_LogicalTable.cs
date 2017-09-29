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
		VButtonObject = GameObject.Find ("ORBooleanTableButton");
		table = GameObject.Find ("LogicalORTableSketch");

		VButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		table.GetComponent<MeshRenderer> ().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		
		Debug.Log ("Button down");
		table.GetComponent<MeshRenderer> ().enabled = true;
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Button up");
		table.GetComponent<MeshRenderer> ().enabled = false;
	}
}
