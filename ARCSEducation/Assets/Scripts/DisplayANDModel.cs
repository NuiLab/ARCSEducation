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

  public GameObject andModel;
  public GameObject andTable;

	// Use this for initialization
	void Start ()
	{
    	//ANDmodel = GameObject.Find("LogicalANDModel");
    	//table = GameObject.Find("LogicalANDTable");

		// start with the model not displaying
		//ANDmodel.GetComponent<Renderer> ().enabled = false;
		modelContainer = GameObject.Find("AndModels");
    hideModels();
    	
		AndVbButton = GameObject.Find ("DisplayANDModelButton");
		AndVbButton.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
    	modelUtility = new ModelUtility(modelContainer);

	}
	
	// Update is called once per frame

  public void hideModels() {
    andModel.GetComponent<MeshRenderer>().enabled = false;
    andTable.GetComponent<MeshRenderer>().enabled = false;
    modelIsVisible = false;
  }

  public void showModels() {
    andModel.GetComponent<MeshRenderer>().enabled = true;
    andTable.GetComponent<MeshRenderer>().enabled = true;
    modelIsVisible = true;
  }
  public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
    //modelUtility.disableAllModels();

    //modelUtility.activateGameObj(ANDGameObject);
		Debug.Log("AND Model Virtual Button Down");
		if (modelIsVisible) {
			//ANDmodel.GetComponent<Renderer> ().enabled = true;
			hideModels();
		}
		else {
			showModels();
			//ANDmodel.GetComponent<Renderer> ().enabled = false;
		}

  }

  public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Logical AND Model Button UP");
  }
}

