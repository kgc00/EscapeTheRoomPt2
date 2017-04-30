using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPuzzleManager : MonoBehaviour {

    public GameObject winSparkle;
    public int order = 1;
    EscapeScript es;


    // Use this for initialization
    void Start()
    {
        es = FindObjectOfType<EscapeScript>();
        order = 1;
    }

    public void PlayMusic()
    {
        
        gameObject.GetComponent<AudioSource>().Play();
        GameObject sparkle = Instantiate(winSparkle, new Vector3(transform.GetComponent<SoundPuzzleManager>().transform.position.x, transform.GetComponent<SoundPuzzleManager>().transform.position.y + 6, transform.GetComponent<SoundPuzzleManager>().transform.position.z), Quaternion.identity);
        Destroy(sparkle, 3);
        es.hasHint = true;
    }

    // Update is called once per frame
    void Update()
    {
     
        //if (order == 7)
        //{
        //    Debug.Log(order);
        //    gameObject.GetComponent<AudioSource>().Play();
        //    GameObject sparkle = Instantiate(winSparkle, new Vector3(transform.GetComponent<SoundPuzzleManager>().transform.position.x, transform.GetComponent<SoundPuzzleManager>().transform.position.y + 6, transform.GetComponent<SoundPuzzleManager>().transform.position.z), Quaternion.identity);
        //    Destroy(sparkle, 3);
        //}
    }
}
