using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3Script : MonoBehaviour {

    //Alcohol
    ButtonPuzzleScript bps;
    public GameObject button3FX1;
    public GameObject button3FX2;
    public GameObject button3FX3;
    public GameObject ps1;
    public GameObject ps2;
    public GameObject ps3;

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
        if (bps.order == 1)
        {
            bps.order++;
            button3FX1 = Instantiate(ps1, new Vector3(transform.GetComponentInChildren<Button3Script>().transform.position.x, transform.GetComponentInChildren<Button3Script>().transform.position.y + 4, transform.GetComponentInChildren<Button3Script>().transform.position.z + 2), Quaternion.identity);
        }
        else if (bps.order == 4)
        {
            bps.order++;
            button3FX2 = Instantiate(ps2, new Vector3(transform.GetComponentInChildren<Button3Script>().transform.position.x, transform.GetComponentInChildren<Button3Script>().transform.position.y + 6, transform.GetComponentInChildren<Button3Script>().transform.position.z), Quaternion.identity);
        }
        else if (bps.order == 6)
        {
            bps.order++;
            button3FX3 = Instantiate(ps3, new Vector3(transform.GetComponentInChildren<Button3Script>().transform.position.x, transform.GetComponentInChildren<Button3Script>().transform.position.y + 4.5f, transform.GetComponentInChildren<Button3Script>().transform.position.z - 7.5f), Quaternion.identity);
        }
        else
        {
            bps.ResetCounter();
        }
    }
}
