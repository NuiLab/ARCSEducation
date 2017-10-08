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

	private bool OrModelVisible; 
  	private ModelUtility modelUtility;

	// Use this for initialization
	void Start () {
		//ORGameObject = GameObject.Find ("LogicalORModel");
        //table = GameObject.Find("LogicalORTable");
        modelContainer = GameObject.Find("OrModels");

        //modelUtility.Hidden(true);
        OrModelVisible = false;

		VButtonObj = GameObject.Find ("DisplayORModelButton");
		VButtonObj.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
        modelUtility = new ModelUtility(modelContainer);


	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {


		Debug.Log ("Logical OR Button down");
		if (OrModelVisible){
			modelUtility.Hidden (false);
        } else {
        	modelUtility.Hidden(true);
        }

        OrModelVisible = !OrModelVisible;

	}


	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Logical OR Button up");
	}
}
