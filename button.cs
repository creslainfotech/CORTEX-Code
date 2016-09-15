using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;



public class button : MonoBehaviour
{
   public void changescene(string scenename) // reload game
        {
        SceneManager.LoadScene("game");
        }
    public void gameexit(string exit1) // exit game
    {
        Debug.Log("Exit");
        Application.Quit(); // quit application
       
    }

    public void turotial()
    {
   
    }
    public void googleplay1(string achivement1) // show achivements
    {
        Social.ShowAchievementsUI ();
    }

    public void googleplay2(string leaderboard1) // show leaderboard
    {
        Social.ShowLeaderboardUI();
    }

        public void mainscene1() //show main scene
    {
        SceneManager.LoadScene("main");
    }
}
