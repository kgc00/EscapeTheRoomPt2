using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2Script : MonoBehaviour {

    //Cat
    ButtonPuzzleScript bps;

    // Use this for initialization
    void Start()
    {
        bps = FindObjectOfType<ButtonPuzzleScript>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Pressed(int order)
    {
        if (bps.order == 3)
        {
            bps.order++;
        } else if (bps.order == 5)
        {
            bps.order++;
        }
        else
        {
            bps.order = 1;
        }
    }
}
