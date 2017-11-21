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
    public QuestionResponses answers;

    private string choiceSelected;

    private List<string> questions;
    private string difficulty;

    public int questionIndex = 0;

    private bool routineBusy = false;

    private string mode;

    void onAwake() {
    }
	// Use this for initialization
	void Start () {
		choiceSelected = "";
    mode = PlayerPrefs.GetString("GameMode");
    Debug.Log("Current game mode is" + mode);
    answers.initQuestionResponseSetup();
    initQuestions();
    iterate();
	}
	
	// Update is called once per frame
	void Update () {
        setChoice();
        if (!choiceSelected.Equals("") && !routineBusy){
          StartCoroutine(checkAnswer());

        }
	}

    private void setChoice(){
      Debug.Log("We are here 44");
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

      //string diff = difficulty;
      difficulty = PlayerPrefs.GetString("Difficulty");
      //Debug.Log("Assigning problem set to questions");
      if (difficulty.Equals("Easy"))
        questions.AddRange(easyBinaryArray);
      else if (difficulty.Equals("Medium"))
        questions.AddRange(mediumBinaryArray);
      else if (difficulty.Equals("Hard"))
        questions.AddRange(hardBinaryArray);

      target_question.setText(questions[0]);
      answers.nextAnswerPool();
    }

    private void nextQuestion(){
      int nextIndex = ++questionIndex;
      if (nextIndex < questions.Count) {
        target_question.setText(questions[nextIndex]);
        answers.nextAnswerPool();
      } else {
        target_question.setText("Game Over");
      }
    }

  private IEnumerator checkAnswer() {
    routineBusy = true;
    bool ans = answers.verifyChoice(choiceSelected);
    if (ans) {
      target_question.setText("Correct");
      yield return new WaitForSeconds(5);
      choiceSelected = "";
      resetButtons();
      nextQuestion();
      routineBusy = false;
    } else {
      target_question.setText("Wrong");
      yield return new WaitForSeconds(5);
      choiceSelected = "";
      resetButtons();
      nextQuestion();
      routineBusy = false;
    }
  
  
  }

  private void resetButtons() {
    button_A.selected = false;
    button_B.selected = false;
    button_C.selected = false;
    button_D.selected = false;
  }
}
