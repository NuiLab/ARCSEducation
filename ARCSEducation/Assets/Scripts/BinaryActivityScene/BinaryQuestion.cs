using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BinaryQuestion : MonoBehaviour {

    /*
        Responsibility of this class is to:
        Maintain State of the current string being displayed
     */
    private string currentValue;
    private GameObject gameobject_text;
    private TextMeshPro textComponent;

	// Use this for initialization
	void Start () {
		gameobject_text = this.transform.GetChild(0).gameObject;
        textComponent = gameobject_text.GetComponent<TextMeshPro>();

	}
	
	// Update is called once per frame
	void Update () {
		textComponent.text = currentValue;
	}

    public string setText(string v){
        return currentValue = v;
    }

    public string getText(){
        return currentValue;
    }
}
