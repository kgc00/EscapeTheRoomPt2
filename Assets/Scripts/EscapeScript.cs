using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeScript : MonoBehaviour
{

    bool end = false;
    float timer;
    float dialogueTimer;
    public float dialogueWaitTime = 5f;
    float msgWaitTime = 1.5f;
    public string npcDialogueText;
    public bool hasHint = false;
    public Button musicButton;
    public Button hintButton;
    public Image soundPuzzleRewardImage;
    public Image hintImage;
    int musicButtonClicked;
    int hintButtonClicked;

    // Use this for initialization  
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Should work");
            
        } else if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("Should work");
            
        }
    }

    public void MusicButtonClicked()
    {
        if (!hasHint)
        {
            musicButton.GetComponent<AudioSource>().Play();
            musicButtonClicked = 0;
        }
        else if (hasHint && musicButtonClicked == 0)
        {
            soundPuzzleRewardImage.GetComponent<Image>().enabled = true;
            musicButtonClicked = 1;
        }
        else
        {
            soundPuzzleRewardImage.GetComponent<Image>().enabled = false;
            musicButtonClicked = 0;
        }
    }

    public void HintButtonClicked()
    {
        if (hintButtonClicked == 0)
        {
            hintImage.GetComponent<Image>().enabled = true;
            hintButtonClicked = 1;
        } else if (hintButtonClicked == 1)
        {
            hintImage.GetComponent<Image>().enabled = false;
            hintButtonClicked = 0;
        }        
    }
}
