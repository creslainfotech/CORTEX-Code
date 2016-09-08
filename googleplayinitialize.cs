using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;

public class googleplayinitialize : MonoBehaviour {
    private float score1;// score
    private float score2; // coin score
    private float score3; // high sore float
    private float score4;// highcoinscore float
    private int highscore; // high score
    private int coinscore; // total coin score
    private int score5; // total number of kill count
    
    void Start() {

        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        
        score1 = PlayerPrefs.GetFloat("score",0);
        score2 = PlayerPrefs.GetFloat("scorecoin",0);
        score3 = PlayerPrefs.GetFloat("HighScore", 0);
        score4 = PlayerPrefs.GetFloat("highcoinscore", 0);
        score5 = PlayerPrefs.GetInt("kill", 0);

        highscore = (int) score2;
        coinscore = (int) score4;


    }


    // Update is called once per frame
    void Update() {

        Social.localUser.Authenticate((bool success) =>{ });
        Social.ReportScore(highscore, "CgkIyLm0hvgNEAIQCg", (bool success) => {
            // update High Score
        });

        Social.ReportScore(coinscore, "CgkIyLm0hvgNEAIQBg", (bool success) => {
            // Update Coin Score
        });

        if (score2 >= 10)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQCQ", 100f , (bool success) => { }); //Collect 10 Coins in 1 Run

        }
        if (score2 >= 20)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQDA", 100f, (bool success) => { }); //Collect 10 Coins in 1 Run

        }
        if (score2 >= 50)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQAg", 100f, (bool success) => { }); //Collect 10 Coins in 1 Run

        }
        if (score2 >= 50)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQAg", 100f, (bool success) => { });//collect 50 coins in 1 Run

        }
        if (score2 >= 100)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQAw", 100f, (bool success) => { });//collect 100 coins in 1 Run

        }
        if (score1 >= 300)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQBA", 100f, (bool success) => { });//collect 300 points in 1 Run

        }
        if (score1 >= 600)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQBQ", 100f, (bool success) => { });//collect 600 points in 1 Run

        }
        if (score1 >= 1200)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQAQ", 100f, (bool success) => { });//collect 1200 points in 1 Run

        }
        if (score3 >= 5000)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQCw", 100f, (bool success) => { });//collect a total of 5000 points

        }
        if (score3 >= 10000)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQCA", 100f, (bool success) => { });//collect a total of 10000 points

        }
        if (score5 >= 25)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQDw", 100f, (bool success) => { });//collect a total of 10000 points

        }
        if (score5 >= 50)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQAg", 100f, (bool success) => { });//collect a total of 10000 points

        }
        if (score5 >= 100)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQEQ", 100f, (bool success) => { });//collect a total of 10000 points

        }
        if (score5 >= 100)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQEQ", 100f, (bool success) => { });//collect a total of 10000 points

        }


        if (score3 >= 100)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQDQ", 100f, (bool success) => { });//collect a total of 10000 points

        }
    }


}
