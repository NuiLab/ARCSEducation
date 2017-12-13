using UnityEngine;
using System.Collections;
using Vuforia;
using Utility;

public class DisplayXORModel : MonoBehaviour, IVirtualButtonEventHandler
{
	// instance variables
	//private GameObject xorModel;
	private GameObject vbButton;
	private GameObject modelContainer;
	//private GameObject table;

	private bool modelVisible;
	private ModelUtility modelUtil;

  public GameObject xorModel;
  public GameObject xorTable;
  private MeshRenderer[] renderers;

	// Use this for initialization
	void Start ()
	{
		//xorModel = GameObject.Find("LogicalXorModelMerged");
		//table = GameObject.Find("LogicalXORTable");
		modelContainer = GameObject.Find("XorModels");
    hideModels();

		vbButton = GameObject.Find("DisplayXORModelButton");
		vbButton.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		modelUtil = new ModelUtility(modelContainer);
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

  public void showModels(){
    xorModel.GetComponent<MeshRenderer>().enabled = true;
    xorTable.GetComponent<MeshRenderer>().enabled = true;
    modelVisible = true;
  }

  public void hideModels(){
    xorModel.GetComponent<MeshRenderer>().enabled = false;
    xorTable.GetComponent<MeshRenderer>().enabled = false;
    modelVisible = false;
  }


	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {

		Debug.Log("Logical XOR Button down");
		if (modelVisible){
			hideModels();
		} else {
			showModels();
		}

	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		Debug.Log("Logical XOR Button up");
	}
}

