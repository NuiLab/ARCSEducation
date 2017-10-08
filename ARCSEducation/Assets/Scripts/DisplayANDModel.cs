using UnityEngine;
using Vuforia;
using System.Collections;
using Utility;

public class DisplayANDModel : MonoBehaviour, IVirtualButtonEventHandler
{
  	GameObject ANDmodel;
	bool modelIsVisible;
  	//GameObject table;
	GameObject AndVbButton;

  	ModelUtility modelUtility;

	// Use this for initialization
	void Start ()
	{
    	ANDmodel = GameObject.Find("LogicalANDModel");
    	modelUtility = new ModelUtility(ANDmodel);

		// start with the model not displaying
		//ANDmodel.GetComponent<Renderer> ().enabled = false;
		modelIsVisible = false;
    	
		AndVbButton = GameObject.Find ("DisplayANDModelButton");
		AndVbButton.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

  public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
    //modelUtility.disableAllModels();

    //modelUtility.activateGameObj(ANDGameObject);
		Debug.Log("AND Model Virtual Button Down");
		if (modelIsVisible) {
			//ANDmodel.GetComponent<Renderer> ().enabled = true;
			modelUtility.Hidden(false);
		}
		else {
			modelUtility.Hidden(true);
			//ANDmodel.GetComponent<Renderer> ().enabled = false;
		}

		modelIsVisible = !modelIsVisible;


  }

  public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Logical AND Model Button UP");
  }
}

