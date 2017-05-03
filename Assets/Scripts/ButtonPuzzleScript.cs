using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzleScript : MonoBehaviour {

    public GameObject winSparkle;
    public int order = 1;
    CrystalManager cm;
    Button1Script b1s;
    Button2Script b2s;
    Button3Script b3s;
    GameObject sparkle;
    bool finishedLogic = false;

    // Use this for initialization
    void Start () {
        cm = FindObjectOfType<CrystalManager>();
        b1s = FindObjectOfType<Button1Script>();
        b2s = FindObjectOfType<Button2Script>();
        b3s = FindObjectOfType<Button3Script>();
    }

    // Update is called once per frame
    void Update() {
        if (order == 7)
        {
            WinLogic();
        }
    }

    public void ResetCounter()
    {
        if (order != 7)
        {
            order = 1;
            Destroy(b1s.button1FX);
            Destroy(b2s.button2FX1);
            Destroy(b2s.button2FX2);
            Destroy(b3s.button3FX1);
            Destroy(b3s.button3FX2);
            Destroy(b3s.button3FX3);
        }
    }

    void WinLogic()
    {
        if (!finishedLogic)
        {
            finishedLogic = true;
            cm.canPickUp = true;
            sparkle = Instantiate(winSparkle, new Vector3(transform.GetComponentInChildren<Button2Script>().transform.position.x, transform.GetComponentInChildren<Button2Script>().transform.position.y + 6, transform.GetComponentInChildren<Button2Script>().transform.position.z), Quaternion.identity);
            Destroy(sparkle, 5);
            Destroy(b1s.button1FX, 5);
            Destroy(b2s.button2FX1, 5);
            Destroy(b2s.button2FX2, 5);
            Destroy(b3s.button3FX1, 5);
            Destroy(b3s.button3FX2, 5);
            Destroy(b3s.button3FX3, 5);
        }
    }
}
