using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coinscript : MonoBehaviour {

    private score thecoinscore;
    public float speed = 1; // Use this for initialization
    void Start()
    {
        thecoinscore = FindObjectOfType<score>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.down * 2 * speed * Time.deltaTime;

           
      
    }

    void OnCollisionEnter2D(Collision2D col2)
    {
        Debug.Log("trigger3");
        if (col2.gameObject.layer == 8) // Checking the colliton with the player
        {
            thecoinscore.coinscore = thecoinscore.coinscore + 1; // Adding coin score
            Debug.Log("coinscore"); 
            GameObject coins1 = GameObject.Find("Coin"); // finding the game object
            Destroy(coins1);
        }

      
    }
   
}