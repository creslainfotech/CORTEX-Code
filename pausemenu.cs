using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour {

    GameObject[] pauseObjects;
   void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();
    }

                                                                                   //Reloads the Level
    public void Reload()    
    {
        AudioListener.pause = false;
        SceneManager.LoadScene("game");
    }
        
                                                                                    //controls the pausing of the scene
    public void pauseControl()  
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
            AudioListener.pause = true;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
            AudioListener.pause = false;
        }
    }

    public void gameexit() // exit game
    {
        Application.Quit(); // quit application

    }

    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
          
        }
    }

                                                                                    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
    
}
