using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class player2 : MonoBehaviour
{
    public float playerboundar = 1;
    Rigidbody2D mybody2;
    public float moveforce = 1; //force to push the player2 (mybody1)


    // Player (Character left)
    void Start()
    {
        mybody2 = this.GetComponent<Rigidbody2D>();
    }

    // 
    void FixedUpdate()
    {
              

        Vector3 pos1 = transform.position;
        Vector3 moveplayer2 = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal1"), 0, 0) * moveforce * Time.deltaTime; // taking input from controller 
        pos1 += moveplayer2;
        mybody2.AddForce(moveplayer2); // moving the player 

        // Setting the border limits for movement 
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if (pos1.x + playerboundar > widthOrtho)
        {
            pos1.x = widthOrtho - playerboundar;
        }
        if (pos1.x - playerboundar < -widthOrtho)
        {
            pos1.x = -widthOrtho + playerboundar;
        }

        transform.position = pos1;


    }
}
