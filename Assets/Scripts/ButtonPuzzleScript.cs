using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzleScript : MonoBehaviour {

    public GameObject winSparkle;
    public int order = 1;
    CrystalManager cm;

	// Use this for initialization
	void Start () {
        cm = FindObjectOfType<CrystalManager>();
	}

    // Update is called once per frame
    void Update() {
            
        //Debug.Log(order);
        if (order == 7)
        {
            cm.canPickUp = true;
            GameObject sparkle = Instantiate(winSparkle, new Vector3(transform.GetComponentInChildren<Button2Script>().transform.position.x, transform.GetComponentInChildren<Button2Script>().transform.position.y + 6, transform.GetComponentInChildren<Button2Script>().transform.position.z), Quaternion.identity);
            Destroy(sparkle, 3);
        }
    }
}
