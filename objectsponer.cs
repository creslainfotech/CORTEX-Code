using UnityEngine;
using System.Collections;

public class objectsponer : MonoBehaviour {

    public GameObject[] ob;
    public Transform campos;
    
	// Use this for initialization
	void Start () {
        ObstacleMaker();

	}
	
	// Update is called once per frame
	void Update ()
    {

        transform.Translate(Vector3.down * PlayerPrefs.GetFloat("speed") * Time.deltaTime );
               
       
	}




    void ObstacleMaker()
    {
        GameObject clone = (GameObject)Instantiate (ob[Random.Range(0,ob.Length)], transform.position, Quaternion.identity);
        clone.name = "Quard"; 
        clone.AddComponent<BoxCollider2D>();
        clone.GetComponent<BoxCollider2D>().isTrigger = true;
        float xx = Random.Range(3, 4);
        Invoke("ObstacleMaker", xx); 
    }

}

