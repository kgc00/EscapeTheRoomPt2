using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalScript : MonoBehaviour {

    CrystalManager cm;
    CrystalWhite1 cw1;
    CrystalWhite2 cw2;
    CrystalWhite3 cw3;

	// Use this for initialization
	void Start () {
        cm = FindObjectOfType<CrystalManager>();
        cw1 = FindObjectOfType<CrystalWhite1>();
        cw2 = FindObjectOfType<CrystalWhite2>();
        cw3 = FindObjectOfType<CrystalWhite3>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseDown()
    {
        if (cw1.properGem && cw2.properGem && cw3.properGem)
        {
            Debug.Log("End Game");
        }
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
