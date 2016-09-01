using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


public class player1 : MonoBehaviour
{
   public float playerboundar = 1f;

    Rigidbody2D mybody1;
    public float moveforce = 1f; //force to push the player1 (mybody1)

 

    // Player 
    void Start()
    {
       
        mybody1 = this.GetComponent<Rigidbody2D>();

    }

    // 
    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        Vector3 moveplayer1 = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"),0,0) * moveforce * Time.deltaTime;

        pos += moveplayer1;
        mybody1.AddForce(moveplayer1);

        // Setting the border limits
        float screenRatio = (float) Screen.width / (float) Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;
        
        if(pos.x + playerboundar > widthOrtho)
        {
            pos.x = widthOrtho - playerboundar; 
        }
        if (pos.x - playerboundar < - widthOrtho)
        {
            pos.x = - widthOrtho + playerboundar;
        }

        transform.position = pos;
    }

  


    }
