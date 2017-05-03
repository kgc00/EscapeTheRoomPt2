using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2Script : MonoBehaviour {

    //Cat
    ButtonPuzzleScript bps;
    public GameObject button2FX1;
    public GameObject button2FX2;
    public GameObject ps1;
    public GameObject ps2;

    // Use this for initialization
    void Start()
    {
        bps = FindObjectOfType<ButtonPuzzleScript>();
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

    public void Pressed(int order)
    {
        if (bps.order == 3)
        {
            bps.order++;
            button2FX1 = Instantiate(ps1, new Vector3(transform.GetComponentInChildren<Button2Script>().transform.position.x, transform.GetComponentInChildren<Button2Script>().transform.position.y + 3, transform.GetComponentInChildren<Button2Script>().transform.position.z - 5), Quaternion.identity);
        }
        else if (bps.order == 5)
        {
            bps.order++;
            button2FX2 = Instantiate(ps2, new Vector3(transform.GetComponentInChildren<Button2Script>().transform.position.x, transform.GetComponentInChildren<Button2Script>().transform.position.y + 7, transform.GetComponentInChildren<Button2Script>().transform.position.z), Quaternion.identity);
        }
        else
        {
            bps.ResetCounter();
        }
    }
}
