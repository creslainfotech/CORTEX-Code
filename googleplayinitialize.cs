using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class googleplayinitialize : MonoBehaviour {
    private int coins1;
    public string AchievementId;
    // Use this for initialization
    void Start() {

        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        coins1 = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update() {

        Social.localUser.Authenticate((bool success) =>{ });


        if (coins1 > 100)
        {
            Social.ReportProgress(
                "CgkIyLm0hvgNEAIQAg", 100f , (bool success) => { });

        }



    }


}
