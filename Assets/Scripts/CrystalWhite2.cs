using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalWhite2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    

    public void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
    }

    public void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }
}
