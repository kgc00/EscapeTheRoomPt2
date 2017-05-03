using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PedestalScript : MonoBehaviour {

    CrystalManager cm;
    CrystalWhite1 cw1;
    CrystalWhite2 cw2;
    CrystalWhite3 cw3;
    LevelManagerScript lms;
    float timer;
    bool loadLevel =false;
    public Image endImg;
    Color endImgColor = new Color(1, 1, 1, 0);
    public bool lost = false;

    // Use this for initialization
    void Start () {
        cm = FindObjectOfType<CrystalManager>();
        cw1 = FindObjectOfType<CrystalWhite1>();
        cw2 = FindObjectOfType<CrystalWhite2>();
        cw3 = FindObjectOfType<CrystalWhite3>();
        lms = FindObjectOfType<LevelManagerScript>();
        timer = 3f;
        endImg.color = endImgColor;
        endImg.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (loadLevel)
        {
            endImg.enabled = true;
            timer = timer - Time.deltaTime;
            endImg.color += new Color(endImgColor.r, endImgColor.g, endImgColor.b, .5f) * Time.deltaTime;
            if (timer <= 0f)
            {
                lms.LoadLevel("VictoryScreen");
            }
        }
        if (lost)
        {
            endImg.enabled = true;
            timer = timer - Time.deltaTime;
            endImg.color += new Color(endImgColor.r, endImgColor.g, endImgColor.b, .5f) * Time.deltaTime;
            if (timer <= 0f)
            {
                lms.LoadLevel("GameOverScreen");
            }
        }
	}

    public void OnMouseDown()
    {
        if (cw1.properGem && cw2.properGem && cw3.properGem)
        {
            loadLevel = true;
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
