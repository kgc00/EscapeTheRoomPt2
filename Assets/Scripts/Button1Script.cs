using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1Script : MonoBehaviour {

    ButtonPuzzleScript bps;
    public GameObject ps;
    public GameObject button1FX;

    // Use this for initialization
    void Start () {
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
        if (bps.order == 2)
        {
            bps.order++;
            button1FX = Instantiate(ps, new Vector3(transform.GetComponentInChildren<Button1Script>().transform.position.x, transform.GetComponentInChildren<Button1Script>().transform.position.y + 6, transform.GetComponentInChildren<Button1Script>().transform.position.z), Quaternion.identity);
        }
        else
        {
            bps.ResetCounter();
        }
    }
}
