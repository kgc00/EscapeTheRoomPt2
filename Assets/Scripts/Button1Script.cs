using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1Script : MonoBehaviour {

    //Yay
    ButtonPuzzleScript bps;

	// Use this for initialization
	void Start () {
        bps = FindObjectOfType<ButtonPuzzleScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Pressed(int order)
    {
        if (bps.order == 2)
        {
            bps.order++;
        }
        else
        {
            bps.order = 1;
        }
    }
}
