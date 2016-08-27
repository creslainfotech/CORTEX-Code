using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour
{
    private score thescore;
  

    public float speed = 1; // Use this for initialization
    void Start()
    {
        thescore = FindObjectOfType<score>();
     
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.down * 2* speed * Time.deltaTime;

    }

void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("trigger2");
        if (gameObject.layer == 9)
        {

          
            Debug.Log("trigger1");
           
            thescore.scoreincreasing = false;
           
            if (thescore.scorecount > thescore.hiscorecount2)
            {
                thescore.hiscorecount1 = thescore.scorecount;
            }
            PlayerPrefs.SetFloat("score", thescore.scorecount);
            PlayerPrefs.SetFloat("Highscore", thescore.hiscorecount1);
            SceneManager.LoadScene("sceen2");
        }

    }

   

}
