using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3Script : MonoBehaviour {

    //Alcohol
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
        if (bps.order == 1)
        {
            bps.order++;
        }
        else if (bps.order == 4)
        {
            bps.order++;
        }
        else if (bps.order == 6)
        {
            bps.order++;
        }
        else
        {
            bps.order = 1;
        }
    }
}
