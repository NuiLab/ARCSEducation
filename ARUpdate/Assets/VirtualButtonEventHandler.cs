using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler 

{

  public Material easy_VBMaterial;
  public Material easyPressed_VBMaterial;
  public Material medium_VBMaterial;
  public Material mediumPressed_VBMaterial;
  public Material hard_VBMaterial;
  public Material hardPressed_VBMaterial;

  VirtualButtonBehaviour[] virtualBtnBehaviours;

  // Use this for initialization
  void Start () {
    virtualBtnBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

//    for (int i = 0; i < virtualBtnBehaviours.Length; i++)
//    {
//      virtualBtnBehaviours[i].RegisterEventHandler(this);
//      Debug.Log(virtualBtnBehaviours[i].VirtualButtonName);
//    }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
  public void OnButtonPressed(VirtualButtonBehaviour vb)
  {
    Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
  }

  public void OnButtonReleased(VirtualButtonBehaviour vb)
  {
    Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
  }
}
