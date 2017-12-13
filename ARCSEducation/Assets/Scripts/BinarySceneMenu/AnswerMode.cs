using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AnswerMode : MonoBehaviour, IVirtualButtonEventHandler {

  private TextMesh label_text;
  public GameObject vb;
  private GameObject label;

  private string mode;
	// Use this for initialization
	void Start () {
		vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    label = this.transform.GetChild(0).gameObject;
    label_text = label.GetComponent<TextMesh>();
    label_text.fontSize = 11;
    label_text.text = "Binary";
    mode = "Binary";
    PlayerPrefs.SetString("GameMode", mode);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void OnButtonPressed (VirtualButtonAbstractBehaviour  vb) {
    toggleModeButton();
  }

  public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
    PlayerPrefs.SetString("GameMode", mode);
  }

  public void toggleModeButton() {
    if (mode.Equals("Binary")){
      label_text.text = "Hex";
      mode="Hex";
    } else if (mode.Equals("Hex")){
      label_text.text = "Binary";
      mode="Binary";
    }
  }
}
