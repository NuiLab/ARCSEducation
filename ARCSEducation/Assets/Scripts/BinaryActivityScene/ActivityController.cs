using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class ActivityController : MonoBehaviour {

    public ChoiceButton button_A;
    public ChoiceButton button_B;
    public ChoiceButton button_C;
    public ChoiceButton button_D;
    public BinaryQuestion target_question;

    private string choiceSelected;

    private List<string> questions;
    private string difficulty = "Medium";

    private int questionIndex = 0;

    void onAwake() {
    }
	// Use this for initialization
	void Start () {
		choiceSelected = "";
    initQuestions();
    iterate();
    nextQuestion();
    nextQuestion();
    nextQuestion();
    nextQuestion();
	}
	
	// Update is called once per frame
	void Update () {
        setChoice();
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

    private void iterate() {
        foreach( var q in questions) {
            Debug.Log(q);
        }
    }

    private void initQuestions(){
      questions = new List<string>();
      string[] easyBinaryArray = new string[] { 
                                          "0000", 
                                          "0001", 
                                          "1010", 
                                          "1101", 
                                         };
      string[] mediumBinaryArray = new string[] { 
                                            "1010 1111", // 175
                                            "1101 1000", // 216
                                            "0010 1001", // 41
                                            "1011 1111" // 191
                                          };
      string[] hardBinaryArray = new string[] { 
                                          "1011 1010 1111 0001", // 47857
                                          "1000 0010 0001 1101", // 33309
                                          "0001 1111 0101 0011", // 8019
                                          "1111 0001 1010 1011"  // 61867
                                          };

      string diff = difficulty;
      //string diff = PlayerPrefs.GetString("Difficulty");
      //Debug.Log("Assigning problem set to questions");
      if (diff.Equals("Easy"))
        questions.AddRange(easyBinaryArray);
      else if (diff.Equals("Medium"))
        questions.AddRange(mediumBinaryArray);
      else if (diff.Equals("Hard"))
        questions.AddRange(hardBinaryArray);

      target_question.setText(questions[0]);
    }

    private void nextQuestion(){
      int nextIndex = ++questionIndex;
      if (nextIndex < questions.Count) {
        target_question.setText(questions[nextIndex]);
      } else {
        target_question.setText("Game Over");
      }
    }

    private void initAnswers() {

    }
}
