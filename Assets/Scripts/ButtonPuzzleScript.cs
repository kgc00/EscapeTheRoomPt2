using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzleScript : MonoBehaviour {

    public GameObject winSparkle;
    public int order = 0;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
            
        //Debug.Log(order);
        if (order == 7)
        {
            Debug.Log("YAY");
            GameObject sparkle = Instantiate(winSparkle, new Vector3(transform.GetComponentInChildren<Button2Script>().transform.position.x, transform.GetComponentInChildren<Button2Script>().transform.position.y + 6, transform.GetComponentInChildren<Button2Script>().transform.position.z), Quaternion.identity);
            Destroy(sparkle, 3);
        }
    }
}
