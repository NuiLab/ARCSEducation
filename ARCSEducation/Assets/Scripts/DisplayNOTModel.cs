using UnityEngine;
using System.Collections;
using Vuforia;
using Utility;

public class DisplayNOTModel : MonoBehaviour, IVirtualButtonEventHandler
{
	private GameObject notModel;
	private GameObject vbButton;
	private bool modelVisible;
	private ModelUtility modelUtil;

	// Use this for initialization
	void Start ()
	{
		notModel = GameObject.Find("LogicalNotModelMerged");
		modelUtil = new ModelUtility(notModel);

		modelVisible = false;

		vbButton = GameObject.Find("DisplayNOTModelButton");
		vbButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler (this);

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {

		Debug.Log("Logical NOT Button down");
		if (modelVisible)
			modelUtil.Hidden(false);
		else 
			modelUtil.Hidden(true);

		modelVisible = !modelVisible;
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
		Debug.Log("Logical NOT Button UP");
	}
}

