using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class EasyVBScript : MonoBehaviour, IVirtualButtonEventHandler {


	private GameObject VButtonObj;
	private GameObject modelContainer;
	private bool isVisible;

	// Use this for initialization
	void Start () {
		VButtonObj = GameObject.Find("Easy");
		VButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	#region IVirtualButtonEventHandler implementation

	public void OnButtonPressed (VirtualButtonBehaviour vb)
	{
		Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
	}

	public void OnButtonReleased (VirtualButtonBehaviour vb)
	{
		Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
	}

	#endregion
}
