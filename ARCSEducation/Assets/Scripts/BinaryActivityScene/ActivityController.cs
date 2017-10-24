using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ActivityController : MonoBehaviour {

    public ChoiceButton button_A;
    public ChoiceButton button_B;
    public ChoiceButton button_C;
    public ChoiceButton button_D;
    public BinaryQuestion binary_question;

    private string choiceSelected;

	// Use this for initialization
	void Start () {
		choiceSelected = "";
	}
	
	// Update is called once per frame
	void Update () {
        setChoice();
        Debug.Log("Current choice is: " + choiceSelected);
	}

    private void setChoice(){
        if (button_A.selected) 
            choiceSelected = "A";
        else if (button_B.selected)
            choiceSelected = "B";
        else if (button_C.selected)
            choiceSelected = "C";
        else if (button_D.selected)
            choiceSelected = "D";
    }
}
