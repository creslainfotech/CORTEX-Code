using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoredisplay : MonoBehaviour {

    public Text scorefinal;
    public float score01;
	// Use this for initialization
	void Start () {
        score01 = PlayerPrefs.GetFloat("score");
    }
	
	// Update is called once per frame
	void Update () {
        score01 = PlayerPrefs.GetFloat("score");

        scorefinal.text = "" + Mathf.Round(score01);

        
    }
}
