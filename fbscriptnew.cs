using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using Facebook.Unity;


public class fbscriptnew : MonoBehaviour
{

    public GameObject DialogLoggedIn; // for loged in functions
    public GameObject DialogLoggedOut; // for showing login
    public GameObject DialogUsername; // username to display
    public GameObject DialogProfilePic; // profile pic to display
  
    void Awake()
    {
        
      FB.Init(SetInit, OnHideUnity); // initialising 
    }


        void SetInit()
    {

        if (FB.IsLoggedIn) // checking login status
        {
            Debug.Log("FB is logged in");
        }
        else
        {
            Debug.Log("FB is not logged in");
        }

        DealWithFBMenus(FB.IsLoggedIn);

    }

    void OnHideUnity(bool isGameShown)
    {

        if (!isGameShown)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

    }

    public void FBlogin() // login functions
    {

        List<string> permissions = new List<string>();
        permissions.Add("public_profile"); // requesting permision to acces data

        FB.LogInWithReadPermissions(permissions, AuthCallBack);
    }

    void AuthCallBack(IResult result)
    {

        if (result.Error != null)
        {
            Debug.Log(result.Error);
        }
        else
        {
            if (FB.IsLoggedIn)
            {
                Debug.Log("FB is logged in");
            }
            else
            {
                Debug.Log("FB is not logged in");
            }

            DealWithFBMenus(FB.IsLoggedIn);
        }

    }

    void DealWithFBMenus(bool isLoggedIn)
    {

        if (isLoggedIn) //showing the loged in window
        {
            DialogLoggedIn.SetActive(true);
            DialogLoggedOut.SetActive(false);

            FB.API("/me?fields=first_name", HttpMethod.GET, DisplayUsername); // loading facebook username
            FB.API("/me/picture?type=square&height=128&width=128", HttpMethod.GET, DisplayProfilePic); // lodaing facebook profile pic

        }
        else
        {
            DialogLoggedIn.SetActive(false);
            DialogLoggedOut.SetActive(true);
        }

    }

    void DisplayUsername(IResult result) 
    {

        Text UserName = DialogUsername.GetComponent<Text>();

        if (result.Error == null)
        {

            UserName.text = "Let's Go, " + result.ResultDictionary["first_name"]; // showing facebook username

        }
        else
        {
            Debug.Log(result.Error);
        }

    }

    void DisplayProfilePic(IGraphResult result)
    {

        if (result.Texture != null)
        {

            Image ProfilePic = DialogProfilePic.GetComponent<Image>();
            ProfilePic.sprite = Sprite.Create(result.Texture, new Rect(0, 0, 128, 128), new Vector2()); // lodaing facebook profile pic

        }

    }

    public void Share() // share function
    {
        FB.FeedShare(
            string.Empty,
            new Uri("http://www.8stags.in"),
            "Improve Your Brain Skills",
            "Crotex The 1st Dual Charcter single Player Game",
            "Check This Out",
            new Uri("http://www.8stags.in/cortex.png"),
            string.Empty,
            ShareCallback
        );
    }

    void ShareCallback(IResult result)
    {
        if (result.Cancelled)
        {
            Debug.Log("Share Cancelled");
        }
        else if (!string.IsNullOrEmpty(result.Error))
        {
            Debug.Log("Error on share!");
        }
        else if (!string.IsNullOrEmpty(result.RawResult))
        {
            Debug.Log("Success on share");
        }
    }



    public void Invite() // invite function
    {
        FB.Mobile.AppInvite(
            new Uri("https://fb.me/542620622603464"),
            new Uri("http://8stags.in/logo.png"),
            InviteCallback
        );
    }

    void InviteCallback(IResult result)
    {
        if (result.Cancelled)
        {
            Debug.Log("Invite Cancelled");
        }
        else if (!string.IsNullOrEmpty(result.Error))
        {
            Debug.Log("Error on invite!");
        }
        else if (!string.IsNullOrEmpty(result.RawResult))
        {
            Debug.Log("Success on Invite");
        }
    }


}
