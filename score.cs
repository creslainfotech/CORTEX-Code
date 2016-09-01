using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public Text scoretext;
    public Text hiscoretext;

    public float scorecount = 0;
    public float hiscorecount1;
    public float hiscorecount2;
    public float pointspersecond;

    public bool scoreincreasing;

void Start () {
        hiscorecount2 = PlayerPrefs.GetFloat("Highscore");
     
	}
	
	// Update is called once per frame
	void Update () {
        hiscorecount1 = hiscorecount2;
        hiscorecount2 = PlayerPrefs.GetFloat("Highscore");
        if (scoreincreasing)
        {
            scorecount += pointspersecond * Time.deltaTime;
        }
        
      
        scoretext.text = "Score: " + Mathf.Round(scorecount);

        hiscoretext.text = "Highscore: " + Mathf.Round(hiscorecount2);
    }
}
