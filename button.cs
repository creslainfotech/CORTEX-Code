using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class button : MonoBehaviour
{

    public void changescene(string scenename)
        {
        SceneManager.LoadScene("game");
        }
    public void gameexit(string exit1)
    {
        Debug.Log("Exit");
        Application.Quit();
       
    }


}
