using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalGreen : MonoBehaviour {

    CrystalManager cm;

    // Use this for initialization
    void Start()
    {
        cm = FindObjectOfType<CrystalManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
    }

    public void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }

    public void OnMouseDown()
    {
        if (cm.canPickUp)
        {
            cm.holdingGreen = true;
            Destroy(gameObject);
        }
    }
}
