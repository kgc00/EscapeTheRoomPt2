using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPuzzleButton1 : MonoBehaviour {

    //Yay
    SoundPuzzleManager spm;

    // Use this for initialization
    void Start()
    {
        spm = FindObjectOfType<SoundPuzzleManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        Pressed(spm.order);
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
    }

    public void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }

    public void Pressed(int order)
    {
        if (spm.order == 3)
        {
            spm.order++;
            
        }
        else
        {
            spm.order = 1;
        }
    }

}
