using UnityEngine;
using System.Collections;
using Vuforia;
using Utility;

public class DisplayXORModel : MonoBehaviour, IVirtualButtonEventHandler
{
	// instance variables
	private GameObject xorModel;
	private GameObject vbButton;
	private bool modelVisible;
	private ModelUtility modelUtil;

	// Use this for initialization
	void Start ()
	{
		xorModel = GameObject.Find("LogicalXorModelMerged");
		modelUtil = new ModelUtility(xorModel);

		modelVisible = false;

		vbButton = GameObject.Find("DisplayXORModelButton");
		vbButton.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}


	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {

		Debug.Log("Logical XOR Button down");
		if (modelVisible){
			modelUtil.Hidden(false);
		} else {
			modelUtil.Hidden(true);
		}

		modelVisible = !modelVisible;
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		Debug.Log("Logical XOR Button up");
	}
}

