using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DifficultySelectionButton : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vB;
	private GameObject vbPlane;
	private Renderer vbRend;
	public Material[] material;

	private GameObject vbLabel;
	private TextMesh labelTextMesh;


	// used to determine if the button has been selected
	public static bool easy_selected = false;
	public static bool med_selected = false;
	public static bool hard_selected = false;

	public DifficultySelectionButton easy;
	public DifficultySelectionButton medium;
	public DifficultySelectionButton hard;

	// Use this for initialization
	void Start () {
		vB = this.transform.parent.gameObject;
		vB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

		vbPlane = GetComponent<Renderer>().gameObject;

		vbRend = GetComponent<Renderer>();
		vbRend.enabled = true;
		vbRend.sharedMaterial = material[1];

		// instantiate label reference
		vbLabel = this.transform.GetChild(0).gameObject;
		labelTextMesh = vbLabel.GetComponent<TextMesh>();
		Debug.Log(labelTextMesh.text.ToString());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		Debug.Log(labelTextMesh.text.ToString() + " Button has been pressed");
		//vbPlane.GetComponent<Renderer>().material = active;
		vbRend.sharedMaterial = material[0];

		// button has been selected
		choseDifficulty();
		}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
		Debug.Log(labelTextMesh.text.ToString() + "Button has beenn released");
		//vbPlane.GetComponent<Renderer>().material = inactive;
	}

	public void choseDifficulty ()
	{
		if (labelTextMesh.text.ToString() == "Easy" && easy_selected == false) {
			easy_selected = true;
			med_selected = false;
			hard_selected = false;
			Debug.Log("Easy difficulty was just selected");
		} else

		if (labelTextMesh.text.ToString() == "Medium" && med_selected == false) {
			med_selected = true;
			easy_selected = false;
			hard_selected = false;
			Debug.Log("Medium difficulty was just selected");
		} else

		if (labelTextMesh.text.ToString() == "Hard" && hard_selected == false) {
			hard_selected = true;
			easy_selected = false;
			hard_selected = false;
			Debug.Log("Hard difficulty was just selected");
		} 
	}
}
