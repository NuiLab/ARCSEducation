using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using Utility;


public class DisplayORModel : MonoBehaviour, IVirtualButtonEventHandler  {

	GameObject ORGameObject;
	private bool OrModelVisible; 
	private GameObject VButtonObj;
  	ModelUtility modelUtility;

	// Use this for initialization
	void Start () {
		ORGameObject = GameObject.Find ("LogicalORModel");
        modelUtility = new ModelUtility(ORGameObject);

        //modelUtility.Hidden(true);
        OrModelVisible = false;

		VButtonObj = GameObject.Find ("DisplayORModelButton");
		VButtonObj.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);


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
