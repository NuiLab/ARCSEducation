using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class OkayButton : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vB;
	private string labelText;
	private Renderer rend;
	public Material[] material;
	private GameObject label;
	public bool selected;

    // Reference to buttons that set difficulty
    public EasyButton easyBut;
    public MediumButton medBut;
    public HardButton hardBut;
    private bool enabled;

	// Use this for initialization
	void Start () {
	    vB = this.transform.parent.gameObject;
		vB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		label = this.transform.GetChild(0).gameObject;
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material[0];
		labelText = label.GetComponent<TextMesh>().text.ToString(); 
		selected = false;

        PlayerPrefs.SetString("Difficulty", "Null");	
	}
	
	// Update is called once per frame
	void Update () {
		toggle();
        setDifficulty();
        Debug.Log("Current difficulty is: " + PlayerPrefs.GetString("Difficulty"));
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		Debug.Log("Okay Button Pressed");
        if( !enabled){
            Debug.Log("Enabled value for Okay button is: " + enabled);
        }
        else {
            Debug.Log("OnButtonPressed enabled");
            LoadActivityScene();
        }
        //toggleMaterialOfButton();
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
		Debug.Log("Okay Button released");
	}

    public bool toggle(){
        //Debug.Log("toggle was called()");
        //Debug.Log("EasyBut val " + easyBut.selected);
        //Debug.Log("MedBut val " + medBut.selected);
        // Debug.Log(hardBut.selected);
        if (easyBut.selected | medBut.selected | hardBut.selected) {
            rend.sharedMaterial = material[1];
        } else
            rend.sharedMaterial = material[0];

        if (rend.sharedMaterial == material[1])
            enabled = true;
        else 
            enabled = false;
        return true;
    }

    public void LoadActivityScene(){
        SceneManager.LoadScene(2);
    }   

    public void setDifficulty(){
        if (easyBut.selected) {
            PlayerPrefs.SetString("Difficulty", "Easy");
            Debug.Log("Easy difficulty selected");
            medBut.selected = false;
            hardBut.selected = false;
        } else if (medBut.selected) {
            PlayerPrefs.SetString("Difficulty", "Medium");
            Debug.Log("Medium difficulty selected");
            easyBut.selected = false;
            hardBut.selected = false;
        } else if (hardBut.selected) {
            PlayerPrefs.SetString("Difficulty", "Hard");
            Debug.Log("Hard difficulty selected");
            easyBut.selected = false;
            medBut.selected = false;
        }
    } 
}
