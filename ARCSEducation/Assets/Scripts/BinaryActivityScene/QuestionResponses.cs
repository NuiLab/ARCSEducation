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

  private string diff;

  public ActivityController controller;

  private string[] easyAnswerKey = new string[] {"A", "C", "C", "C"};
  private string[] mediumAnswerKey = new string[] {"A", "B", "D", "A"};
  private string[] hardAnswerKey = new string[] {"C", "D", "B", "C"};
  private string[] currentAnswerKey;

  private string mode;
	// Use this for initialization
	void Start () {
    //binaryAnswers[0].Clear();
    //nextAnswerPool();
	}

  public void initQuestionResponseSetup() {
    textMesh = GetComponent<TextMeshPro>();
    diff = PlayerPrefs.GetString("Difficulty");
    mode = PlayerPrefs.GetString("GameMode");
    clearAnswerPools();
    //initBinaryAnswers();
    initAnswers(mode);
  }
	
	// Update is called once per frame
	void Update () {
		
	}
  private void clearAnswerPools() {
    foreach (List<string> list in binaryAnswers) {
      list.Clear();
    }
  }

  private string initAnswers(string md) {
    string currentMode = md;
    if (md.Equals("Binary"))
      initBinaryAnswers();
    else
      initHexAnswers();

    return currentMode;
  }
  public void initBinaryAnswers() {
    if (diff.Equals("Easy")) {
      initBinEasyAnswers();
      currentAnswerKey = easyAnswerKey;
    }
    else if (diff.Equals("Medium")) {
      initBinMedAnswers();
      currentAnswerKey = mediumAnswerKey;
    }
    else if (diff.Equals("Hard")) {
      initBinHardAnswers();
      currentAnswerKey = hardAnswerKey;
    }
  }

  public void initHexAnswers() {
    if (diff.Equals("Easy")) {
      initHexEasyAnswers();
      currentAnswerKey = easyAnswerKey;
    }
    else if (diff.Equals("Medium")) {
      initHexMedAnswers();
      currentAnswerKey = mediumAnswerKey;
    }
    else if (diff.Equals("Hard")) {
      initHexHardAnswers();
      currentAnswerKey = hardAnswerKey;
    }
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

  public void initHexEasyAnswers() {
    string[] ans0 = new string[] {"0", "2", "3", "4"};
    string[] ans1 = new string[] {"3", "0", "1", "10"};
    string[] ans2 = new string[] {"7", "E", "A", "5"};
    string[] ans3 = new string[] {"A", "4", "C", "D"};
    
    binaryAnswers[0].AddRange(ans0);
    binaryAnswers[1].AddRange(ans1);
    binaryAnswers[2].AddRange(ans2);
    binaryAnswers[3].AddRange(ans3);
    
  }

  public void initHexMedAnswers() {
    string[] ans0 = new string[] {"AF", "64", "22", "B5"}; // AF
    string[] ans1 = new string[] {"4D", "D8", "86", "B"}; // D8
    string[] ans2 = new string[] {"5C", "C8", "2B", "29"}; // 29
    string[] ans3 = new string[] {"BF", "C9", "84", "B6"}; // VF

    binaryAnswers[0].AddRange(ans0);
    binaryAnswers[1].AddRange(ans1);
    binaryAnswers[2].AddRange(ans2);
    binaryAnswers[3].AddRange(ans3);
    
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
    string[] ans0 = new string[]{"32481", "1832", "47857", "65000"}; // 47857
    string[] ans1 = new string[]{"19239", "21349", "52345", "33309"}; // 33309
    string[] ans2 = new string[]{"8080", "8019", "8018", "8011"}; // 8019
    string[] ans3 = new string[]{"61768", "53234", "61867", "60867"}; // 61867

    binaryAnswers[0].AddRange(ans0);
    binaryAnswers[1].AddRange(ans1);
    binaryAnswers[2].AddRange(ans2);
    binaryAnswers[3].AddRange(ans3);

  }

  public void initHexHardAnswers() {
    string[] ans0 = new string[]{"7EE1", "0728", "BAF1", "FDE8"}; // BAF1
    string[] ans1 = new string[]{"4B27", "5365", "CC79", "821D"}; // 0CED
    string[] ans2 = new string[]{"1F90", "1F53", "1F52", "1F4B"}; // 1F53
    string[] ans3 = new string[]{"F148", "CFF2", "F1AB", "EDC3"}; // F148

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
    int qIndex = controller.questionIndex;
    Debug.Log("Current answer from key is: " + currentAnswerKey[qIndex] + " and user's choice was " + choice);
    if (!currentAnswerKey[qIndex].Equals(choice))
      return false;

    return true;
  }
}
