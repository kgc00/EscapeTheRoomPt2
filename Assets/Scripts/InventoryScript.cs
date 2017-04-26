using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour {

	public int blueScore;
	public int redScore;
	public int greenScore;

	public int circlePresses;
	public int squarePresses;
	public int ovalPresses;

	public float timeLeft;
	public Text timerTextUI;

	// Use this for initialization
	void Start () {
		blueScore = 0;
		redScore = 0;
		greenScore = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft >= 0) {
			timeLeft = timeLeft - Time.deltaTime;
			timerTextUI.text = "Time Left:" + Mathf.Round (timeLeft);
		}
		
	}
}
