﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHolderScript : MonoBehaviour {

    public Canvas canvas;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
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
