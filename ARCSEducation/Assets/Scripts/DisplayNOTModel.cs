using UnityEngine;
using System.Collections;
using Vuforia;
using Utility;

public class DisplayNOTModel : MonoBehaviour, IVirtualButtonEventHandler
{
	//private GameObject notModel;
	private GameObject modelContainer;
	private GameObject vbButton;
	//private GameObject table;

	public bool modelVisible;
	private ModelUtility modelUtil;

  public GameObject notModel;
  public GameObject notTable;

	// Use this for initialization
	void Start ()
	{
		//notModel = GameObject.Find("LogicalNotModelMerged");
		//table = GameObject.Find("LogicalNOTTable");
		modelContainer = GameObject.Find("NotModels");
    hideModels();
		vbButton = GameObject.Find("DisplayNOTModelButton");
		vbButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler (this);
		modelUtil = new ModelUtility(modelContainer);

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

  public void hideModels() {
    notModel.GetComponent<MeshRenderer>().enabled = false;
    notTable.GetComponent<MeshRenderer>().enabled = false;
    modelVisible = false;
  }

  public void showModels(){
    notModel.GetComponent<MeshRenderer>().enabled = true;
    notTable.GetComponent<MeshRenderer>().enabled = true;
    modelVisible = true;
  }

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {

		Debug.Log("Logical NOT Button down");
		if (modelVisible)
      hideModels();
		else
      showModels(); 

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
		Debug.Log("Logical NOT Button UP");
	}
}

