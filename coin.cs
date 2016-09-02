using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour
{

    public GameObject[] ob1;
    public Transform campos1;

    // Use this for initialization
    void Start()
    {
        CoinMaker();

    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector3.down * PlayerPrefs.GetFloat("speed") * Time.deltaTime);
    }

    void CoinMaker()
    {
        GameObject clone = (GameObject)Instantiate(ob1[Random.Range(0, ob1.Length)], transform.position, Quaternion.identity);
        clone.name = "Coin";
        clone.AddComponent<BoxCollider2D>();
        clone.GetComponent<BoxCollider2D>().isTrigger = true;
        float xyx = Random.Range(7, 8);
        Invoke("CoinMaker", xyx);
    }
}

