using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalWhite2 : MonoBehaviour {

    CrystalManager cm;
    public Material blueMat;
    public Material greenMat;
    public Material redMat;
    public Material whiteMat;
    bool isColored = false;
    public bool properGem = false;

    // Use this for initialization
    void Start()
    {
        cm = FindObjectOfType<CrystalManager>();
    }

    // Update is called once per frame
    void Update () {
        
	}

    public void OnMouseDown()
    {
        if (!isColored)
        {
            if (cm.activeGem == 1 && cm.holdingBlue)
            {
                gameObject.GetComponent<Renderer>().material = blueMat;
                cm.holdingBlue = false;
                cm.activeGem = 0;
                properGem = false;
                isColored = true;
            }
            else if (cm.activeGem == 2 && cm.holdingGreen)
            {
                gameObject.GetComponent<Renderer>().material = greenMat;
                cm.holdingGreen = false;
                cm.activeGem = 0;
                properGem = true;
                isColored = true;
            }
            else if (cm.activeGem == 3 && cm.holdingRed)
            {
                gameObject.GetComponent<Renderer>().material = redMat;
                cm.holdingRed = false;
                cm.activeGem = 0;
                properGem = false;
                isColored = true;
            }
        }
        else if (isColored)
        {
            if (gameObject.GetComponent<Renderer>().material.name == "Material_003 (Instance)")
            {
                cm.ObtainedBlue();
                gameObject.GetComponent<Renderer>().material = whiteMat;
                isColored = false;
            }
            else if (gameObject.GetComponent<Renderer>().material.name == "Material_002 (Instance)")
            {
                cm.holdingGreen = true;
                gameObject.GetComponent<Renderer>().material = whiteMat;
                isColored = false;
                properGem = false;
            }
            else if (gameObject.GetComponent<Renderer>().material.name == "Material_001 (Instance)")
            {
                cm.holdingRed = true;
                gameObject.GetComponent<Renderer>().material = whiteMat;
                isColored = false;
            }
        }
    }

    public void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
    }

    public void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(.5f, .5f, .5f);
    }
}
