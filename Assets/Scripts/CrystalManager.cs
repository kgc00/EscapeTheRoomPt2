using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalManager : MonoBehaviour {

    public bool holdingBlue = false;
    public bool holdingGreen = false;
    public bool holdingRed = false;
    //1 is Blue, 2 is Green, 3 is Red
    public int activeGem = 0;
    public bool canPickUp = false;

    // Use this for initialization
    void Start () {
        //holdingBlue = true;
        //holdingGreen = true;
        //holdingRed = true;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(activeGem);
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    holdingBlue = false;
        //} else if (Input.GetKeyDown(KeyCode.M))
        //{
        //    holdingBlue = true;
        //}
    }

    public void ActivateBlue()
    {
        if (holdingBlue)
        {
            activeGem = 1;
        }
    }

    public void ActivateGreen()
    {
        if (holdingGreen)
        {
            activeGem = 2;
        }
    }

    public void ActivateRed()
    {
        if (holdingRed)
        {
            activeGem = 3;
        }
    }

    public void ObtainedBlue()
    {
        holdingBlue = true;
    }

    public void ObtainedRed()
    {
        holdingRed = true;
    }

    public void ObtainedGreen()
    {
        holdingGreen = true;
    }

    public void PlacedBlue()
    {
        holdingBlue = false;
    }

    public void PlacedGreen()
    {
        holdingBlue = false;
    }

    public void PlacedRed()
    {
        holdingBlue = false;
    }
}
