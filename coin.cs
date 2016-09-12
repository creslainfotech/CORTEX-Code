using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour
{

    public GameObject[] ob1; // new gameobect for coin spawning
    public Transform campos1; // chosing the camera

    void Start()
    {
        CoinMaker(); // calling the function

    }

    void Update()
    {
      transform.Translate(Vector3.down * PlayerPrefs.GetFloat("speed") * Time.deltaTime);
    }

    void CoinMaker()
    {
        GameObject clone = (GameObject)Instantiate(ob1[Random.Range(0, ob1.Length)], transform.position, Quaternion.identity); // cloneing the coin 
        clone.name = "Coin"; // assigning name to the clone
        clone.AddComponent<BoxCollider2D>(); // adding box collider to the clone
        clone.GetComponent<BoxCollider2D>().isTrigger = true; // setting the box collider trigger 
        float xyx = Random.Range(7, 8); // time between each coins
        Invoke("CoinMaker", xyx); // invoiking the function with respect to time xyz
    }
}

