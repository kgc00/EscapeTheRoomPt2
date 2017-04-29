using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPuzzleButton2 : MonoBehaviour {


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
        if (spm.order == 1)
        {
            spm.order++;
            
        }
        else if (spm.order == 2)
        {
            spm.order++;
           
        }
        else if (spm.order == 4)
        {
            spm.order++;
           
        }
        else
        {
            spm.order = 1;
        }
    }
}
