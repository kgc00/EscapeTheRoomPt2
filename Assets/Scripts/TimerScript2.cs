using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript2 : MonoBehaviour {

	public Image circularSlider;
	public float time;
    LevelManagerScript lms;
    PedestalScript ps;

    // Use this for initialization
    void Start () {
        ps = FindObjectOfType<PedestalScript>();
        lms = FindObjectOfType<LevelManagerScript>();
		circularSlider.fillAmount = 1.0f;
		time = 600.0f;
	}
	
	// Update is called once per frame
	void Update () {
		circularSlider.fillAmount -= Time.deltaTime/time;
        if (time <= 0)
        {
            ps.lost = true;
        }
	}
}
