﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocationScript : MonoBehaviour {

    //public int myMoveInt;
    public Vector3 myMoveLocation;
    public EscapeController ec;
    public EscapeScript es;
    public GameObject myPlay;

	// Use this for initialization
	void Start () {
        myMoveLocation = transform.position;
	}

    public void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
    }

    public void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }

    // Update is called once per frame
    void Update () {
		
	}  
}
