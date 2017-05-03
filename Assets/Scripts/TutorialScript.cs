using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour {

    public Canvas tutorialCanvas;
    bool showingCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TutorialButtonClicked()
    {
        if (!showingCanvas)
        {
            tutorialCanvas.GetComponent<Canvas>().enabled = true;
            showingCanvas = true;
        }
        else
        {
            tutorialCanvas.GetComponent<Canvas>().enabled = false;
            showingCanvas = false;
        }
    }
}
