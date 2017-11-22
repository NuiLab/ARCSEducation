using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using Utility;


public class DisplayORModel : MonoBehaviour, IVirtualButtonEventHandler  {

	//private GameObject ORGameObject;
	private GameObject VButtonObj;
	//private GameObject table;
	private GameObject modelContainer;

	public bool OrModelVisible; 
  	private ModelUtility modelUtility;

  public GameObject ORmodel;
  public GameObject ORtable;

	// Use this for initialization
	void Start () {
		//ORGameObject = GameObject.Find ("LogicalORModel");
        //table = GameObject.Find("LogicalORTable");
    modelContainer = GameObject.Find("OrModels");
    hideModels();

		VButtonObj = GameObject.Find ("DisplayORModelButton");
		VButtonObj.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
        modelUtility = new ModelUtility(modelContainer);


	}
	
	public void hideModels() {
    ORmodel.GetComponent<MeshRenderer>().enabled = false;
    ORtable.GetComponent<MeshRenderer>().enabled = false;
    OrModelVisible = false;
  }

  public void showModels() {
    ORmodel.GetComponent<MeshRenderer>().enabled = true;
    ORtable.GetComponent<MeshRenderer>().enabled = true;
    OrModelVisible = true;
  }



	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		if (OrModelVisible){
			hideModels();
        } else {
        	showModels();
        }
	}


	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Logical OR Button up");
	}
}
