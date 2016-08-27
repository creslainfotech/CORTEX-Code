using UnityEngine;
using System.Collections;

public class Obstuclekill : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter2D()
    { 

    GameObject cs = GameObject.Find("Quard");
        
                Debug.Log("killq");
                Destroy(cs);
        }
   
}
        

