using UnityEngine;
using Vuforia;
using System.Collections;
using Utility;

public class DisplayANDModel : MonoBehaviour, IVirtualButtonEventHandler
{
  	//private GameObject ANDmodel;
  	//private GameObject table;
  	private GameObject modelContainer;
	private GameObject AndVbButton;
	private bool modelIsVisible;

  	ModelUtility modelUtility;

	// Use this for initialization
	void Start ()
	{
    	//ANDmodel = GameObject.Find("LogicalANDModel");
    	//table = GameObject.Find("LogicalANDTable");

		// start with the model not displaying
		//ANDmodel.GetComponent<Renderer> ().enabled = false;
		modelContainer = GameObject.Find("AndModels");
		modelIsVisible = false;
    	
		AndVbButton = GameObject.Find ("DisplayANDModelButton");
		AndVbButton.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
    	modelUtility = new ModelUtility(modelContainer);

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

