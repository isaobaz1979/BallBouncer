using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchBall : MonoBehaviour
{

    private Rigidbody2D rb;
    
    private gameManager gameManager;

   


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        gameManager = FindObjectOfType<gameManager>();


        // rb.velocity = new Vector2(bounceForce, bounceForce );
    }

    // Update is called once per frame

    void Update()
    {

       
    
    }

   
    

}
