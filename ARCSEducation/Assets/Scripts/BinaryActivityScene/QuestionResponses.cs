using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionResponses : MonoBehaviour {

  private List<List<string>> binaryAnswers = new List<List<string>>(
    new[] { new List<string>(new[] { string.Empty, string.Empty }), 
    new List<string>(new[] { string.Empty, string.Empty }),  
    new List<string>(new[] { string.Empty, string.Empty }),
    new List<string>(new[] { string.Empty, string.Empty }) });

  private List<List<string>> hexAnswers;

  private TextMeshPro textMesh;

  private string diff = "Medium";

  public ActivityController controller;
	// Use this for initialization
	void Start () {
    //binaryAnswers[0].Clear();
    
    //nextAnswerPool();
	}

  public void initQuestionResponseSetup() {
    textMesh = GetComponent<TextMeshPro>();
    clearAnswerPools();
    initBinaryAnswers();
  }
	
	// Update is called once per frame
	void Update () {
		
	}
  private void clearAnswerPools() {
    foreach (List<string> list in binaryAnswers) {
      list.Clear();
    }
  }
  public void initBinaryAnswers() {
    if (diff.Equals("Easy"))
      initBinEasyAnswers();
    else if (diff.Equals("Medium"))
      initBinMedAnswers();
    else if (diff.Equals("Hard"))
      initBinHardAnswers();
  }

  public void initBinEasyAnswers() {
    string[] easyAnswers0 = new string[] {"0", "2", "3", "4"};
    // foreach (string v in easyAnswers0) {
    //   binaryAnswers[0].Add(v);
    // }
    binaryAnswers[0].AddRange(easyAnswers0);

    string[] easyAnswers1 = new string[] {"3", "0", "1", "10"};
    binaryAnswers[1].AddRange(easyAnswers1);

    string[] easyANswer2 = new string[] {"7", "14", "10", "5"};
    binaryAnswers[2].AddRange(easyANswer2);

    string[] easyANswer3 = new string[] {"10", "4", "12", "13"};
    binaryAnswers[3].AddRange(easyANswer3);
  }

  public void initBinMedAnswers() {
    string[] ans0 = new string[] {"175", "100", "34", "181"}; // 175
    string[] ans1 = new string[] {"77", "216", "134", "11"}; // 216
    string[] ans2 = new string[] {"92", "200", "43", "41"}; // 41
    string[] ans3 = new string[] {"191", "201", "132", "182"}; // 191

    binaryAnswers[0].AddRange(ans0);
    binaryAnswers[1].AddRange(ans1);
    binaryAnswers[2].AddRange(ans2);
    binaryAnswers[3].AddRange(ans3);
    
  }

  public void initBinHardAnswers() {
    string[] ans0 = new string[]{"32481", "1832", "49321", "65000"}; // 47857
    string[] ans1 = new string[]{"19239", "21349", "52345", "33309"}; // 33309
    string[] ans2 = new string[]{"8080", "8019", "8018", "8011"}; // 8019
    string[] ans3 = new string[]{"61768", "53234", "61867", "60867"}; // 61867

    binaryAnswers[0].AddRange(ans0);
    binaryAnswers[1].AddRange(ans1);
    binaryAnswers[2].AddRange(ans2);
    binaryAnswers[3].AddRange(ans3);

  }

  public void updateAnswerPanel(int qIndex) {
    Debug.Log(qIndex + " is the current index");
    textMesh.text = "A) " + binaryAnswers[qIndex][0] + "\n" +
                    "B) " + binaryAnswers[qIndex][1] + "\n" +
                    "C) " + binaryAnswers[qIndex][2] + "\n" +
                    "D) " + binaryAnswers[qIndex][3];
  }

  public int nextAnswerPool() {
    int qIndex = controller.questionIndex;
    updateAnswerPanel(qIndex);
    return 0;
  }

  public bool verifyChoice(string choice){
    return true;
  }
}
