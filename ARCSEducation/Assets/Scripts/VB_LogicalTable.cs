using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB_LogicalTable : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject VButtonObject;

	// Use this for initialization
	void Start () {
		VButtonObject = GameObject.Find ("ORBooleanTableButton");
		VButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
	
		Debug.Log ("Button down");
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Button up");
	}
}
