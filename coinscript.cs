using UnityEngine;
using System.Collections;

public class coinscript : MonoBehaviour {



    public float speed = 1; // Use this for initialization
    void Start()
    {
   

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.down * 2 * speed * Time.deltaTime;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("trigger3");
        if (gameObject.layer == 8)
        {
            Debug.Log("triggercoin");
                               
               
           
        }
        GameObject coins1 = GameObject.Find("Coin");
        Destroy(coins1);

    }



}