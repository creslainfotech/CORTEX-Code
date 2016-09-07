using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour
{
    private score thescore; // The Score
    public float speed = 1; // Speed of the obstucle

    void Start() 
    {
        thescore = FindObjectOfType<score>(); // find the game object of type Score and Assign it to thescore
    }

    void Update()
    {
        transform.position += Vector3.down * 2* speed * Time.deltaTime; // Moving the Obstucle Down
    }

    void OnCollisionEnter2D(Collision2D col) // initilaizing collition decctection
    {
        Debug.Log("Collition With Object");
        if (col.gameObject.layer == 8) // Checking the colliton with the player

            {      
                Debug.Log("Collition with the player");
                if (thescore.scorecount > thescore.hiscorecount2) // if New High Score
                    {
                        thescore.hiscorecount1 = thescore.scorecount; // Replace the score with highscore
                    }

            PlayerPrefs.SetFloat("score", thescore.scorecount); //saving score
            PlayerPrefs.SetFloat("scorecoin", thescore.coinscore);// Saving coinscore
            PlayerPrefs.SetFloat("Highscore", thescore.hiscorecount1); // saving highscore
            SceneManager.LoadScene("sceen2"); // Load the Game end scene 
            }

    }

   

}
