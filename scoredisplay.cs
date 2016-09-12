using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoredisplay : MonoBehaviour {

    public Text scorefinal1; // text element
    public Text scorefinal2; // text element
    public float score01; // float score
    public float score02; // float coin score
    public float highsccorecoin; // float high score
    // Use this for initialization
    void Start () {
        score01 = PlayerPrefs.GetFloat("score");    // loading  score
        score02 = PlayerPrefs.GetFloat("scorecoin"); // loading coin score
        highsccorecoin = PlayerPrefs.GetFloat("highcoinscore"); // loading highscore
    }
	
	void Update ()
    {
        score01 = PlayerPrefs.GetFloat("score");                        // loading score
        score02 = PlayerPrefs.GetFloat("scorecoin");                    // loading coin score
        scorefinal1.text = "" + Mathf.Round(score01);                  // displyaing score
        scorefinal2.text = "" + Mathf.Round(score02);                  // displaying coin score
        if (score01 > highsccorecoin)                                // if New High Score
        {
            highsccorecoin = score02;
            PlayerPrefs.SetFloat("highcoinscore", highsccorecoin); // saving coin score
        }

    }
}
