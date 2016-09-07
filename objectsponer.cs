using UnityEngine;
using System.Collections;

public class objectsponer : MonoBehaviour {

    public GameObject[] ob;                                                                                                    // New Object
    public Transform campos;                                                                                                   // Choose Camera
    
	void Start ()

    {
        ObstacleMaker();                                                                                                       // Function call - Obstucle Maker

	}

    
    void Update ()
    {
        transform.Translate(Vector3.down * PlayerPrefs.GetFloat("speed") * Time.deltaTime );                                   // Transform the obstucle postition down;
    }
    
    void ObstacleMaker()                                                                                                       // Function definiton Obstucle maker
    {
        GameObject clone = (GameObject)Instantiate (ob[Random.Range(0,ob.Length)], transform.position, Quaternion.identity);   // Cloning Game Object 
        clone.name = "Quard";                                                                                                  // Assigning name for new game object
        clone.AddComponent<BoxCollider2D>();                                                                                   // Adding box collider to the clone game object
        clone.GetComponent<BoxCollider2D>().isTrigger = true;                                                                  // Triggering Box Collider 
        float xx = Random.Range(3, 4);                                                                                         // Setting time delay
        Invoke("ObstacleMaker", xx);                                                                                           // Invoking obstucle maker
    }

}

