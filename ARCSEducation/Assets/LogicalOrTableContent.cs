using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicalOrTableContent : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start () {

		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "\tp\tq\tp OR q\n" + "\tT\tT\tT\n" + "\tT\tF\tT\n" + "\tF\tT\tT\n" + "\tF\tF\tF";
	}
}
