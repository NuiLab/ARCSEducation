using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour {

  public Button sceneButton;
  private string gameObjectName;
	// Use this for initialization
	void Start () {
    GetThisScene();
    sceneButton.onClick.AddListener(GameSceneOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  private void GetThisScene() {
    gameObjectName = gameObject.name;
  }

  void GameSceneOnClick() {
    //Debug.Log("You have clicked the " + gameObjectName + " activity button");

    if (gameObjectName.Equals("BinaryActivitySceneButton"))
      SceneManager.LoadScene(1);
    if (gameObjectName.Equals("LogicGateReferenceButton"))
      SceneManager.LoadScene(3);
  }

  
}
