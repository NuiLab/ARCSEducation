using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class ChoiceButton : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vB;
    private Renderer rend;
    public Material[] material;
    private GameObject label;
    public bool selected;
    
    private string thisChoiceVal;

    
    public string currentChoice 
    {
        get 
        {
            return thisChoiceVal;
        }

        set 
        {
            thisChoiceVal = value;
        }
    }


	// Use this for initialization
	void Start () {
		vB = this.transform.parent.gameObject;
        vB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        label = this.transform.GetChild(0).gameObject;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        thisChoiceVal = label.GetComponent<TextMeshPro>().text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
        Debug.Log("Choice " + thisChoiceVal + "Button was selected");
        selected = true;
        rend.sharedMaterial = material[1];
    }

    public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
        Debug.Log("Choice "+ thisChoiceVal + " was just released");
        rend.sharedMaterial = material[0];
    }

    
}
