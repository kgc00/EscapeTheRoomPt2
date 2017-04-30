using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHolderScript : MonoBehaviour {

    public Canvas canvas;
    public Button buttonBlue;
    public Button buttonGreen;
    public Button buttonRed;
    CrystalManager cm;

    // Use this for initialization
    void Start () {
        cm = FindObjectOfType<CrystalManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!cm.holdingBlue)
        {
            buttonBlue.enabled = false;
            buttonBlue.image.enabled = false;
        }
        else if (cm.holdingBlue)
        {
            buttonBlue.enabled = true;
            buttonBlue.image.enabled = true;
        }
        if (!cm.holdingGreen)
        {
            buttonGreen.enabled = false;
            buttonGreen.image.enabled = false;
        }
        else if (cm.holdingGreen)
        {
            buttonGreen.enabled = true;
            buttonGreen.image.enabled = true;
        }
        if (!cm.holdingRed)
        {
            buttonRed.enabled = false;
            buttonRed.image.enabled = false;
        }
        else if (cm.holdingRed)
        {
            buttonRed.enabled = true;
            buttonRed.image.enabled = true;
        }
    }

    public void FlipFlopCanvas()
    {
        if (canvas.enabled == true)
        {
            canvas.enabled = false;
        } else
        {
            canvas.enabled = true;
        }
    }
}
