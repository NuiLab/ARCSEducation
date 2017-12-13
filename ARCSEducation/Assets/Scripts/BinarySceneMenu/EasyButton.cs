using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class EasyButton : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vB;
	private string labelText;
	private Renderer rend;
	public Material[] material;
	private GameObject label;
	public bool selected;

    public MediumButton medBut;
    public HardButton hardBut;

	// Use this for initialization
	void Start () {
	    vB = this.transform.parent.gameObject;
		vB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		label = this.transform.GetChild(0).gameObject;
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material[0];
		labelText = label.GetComponent<TextMesh>().text.ToString(); 
        selected = false;
			
	}
	
	// Update is called once per frame
	void Update () {
        toggleMaterialOfButton();
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		Debug.Log("Easy Button Pressed");
        ButtonSelected();
    }
	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
		Debug.Log("Easy Button released");
	}

    public bool toggleMaterialOfButton(){
        if (!selected) {
            rend.sharedMaterial = material[1];
        } else {
            rend.sharedMaterial = material[0];
        }
        return selected;
    }

    public void ButtonSelected() {
        selected = true;
        medBut.selected = false;
        hardBut.selected = false;
    }
}
