using UnityEngine;
using System.Collections;

public class coinkil : MonoBehaviour {

    void OnTriggerEnter2D()
    {

        GameObject coin1 = GameObject.Find("Coin");

        Debug.Log("killC");
        Destroy(coin1);

    }

}


