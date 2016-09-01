using UnityEngine;
using System.Collections;

public class Obstuclekill : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D coll) // on Collition with Obstucle

    {
        if (coll.gameObject.layer == 9)
        { 
             GameObject cs = GameObject.Find("Quard"); // Find game object "Quard" and assign it to  new game object CS
             Debug.Log("Obstucle Kill"); // Debug Obstucle Kill 
             Destroy(cs); // Destroy the game object cs

         }

        if (coll.gameObject.layer == 10)
        {
            GameObject cs = GameObject.Find("Coin"); // Find game object "Quard" and assign it to  new game object CS
            Debug.Log("Obstucle Kill"); // Debug Obstucle Kill 
            Destroy(cs); // Destroy the game object cs

        }
    }
   
}
        

