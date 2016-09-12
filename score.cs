using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public Text scoretext; // Time txt
    public Text scoretext1; // points txt 
    public Text hiscoretext; //high score txt 

    public float scorecount = 0; // time 
    public float hiscorecount1; // highcore present
    public float hiscorecount2; // highcore initial
    public float pointspersecond; // time scale
    public float coinscore; // score 
    public bool scoreincreasing; // Checking time

    void Start ()
    {

        hiscorecount2 = PlayerPrefs.GetFloat("Highscore"); // loading saved highscore value
     
	}
	void Update () {

        hiscorecount1 = hiscorecount2; // swaping highscre values
        hiscorecount2 = PlayerPrefs.GetFloat("Highscore"); // loading highscore

        if (scoreincreasing)
        {
            scorecount += pointspersecond * Time.deltaTime; // score with respect to time
        }

        scoretext1.text = "" + Mathf.Round(coinscore); // display coin score 
        scoretext.text = "" + Mathf.Round(scorecount); // display score 
        hiscoretext.text = "" + Mathf.Round(hiscorecount2); //diplay highscore
    }

    }
