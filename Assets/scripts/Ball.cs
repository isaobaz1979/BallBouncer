using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D rb;
    public float bounceForce;
    public float maxHorizontalSpeed;

    private gameManager gameManager;

    public bool BallActive;
    public Transform StartPoint;

    public int points;
    


    public AudioSource ballBounce;
    public AudioSource ballDead;
    public AudioSource ballBrick;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        gameManager = FindObjectOfType<gameManager>();
     

        // rb.velocity = new Vector2(bounceForce, bounceForce );
    }

    // Update is called once per frame

    void Update()
    {

        if (!BallActive) 
        {

            rb.velocity = Vector2.zero;
            transform.position = StartPoint.position;
        }
        if (rb.velocity.x > maxHorizontalSpeed)
        {
            rb.velocity = new Vector2(maxHorizontalSpeed, rb.velocity.y);

        }else if (rb.velocity.x < -maxHorizontalSpeed)
        {
            rb.velocity = new Vector2(-maxHorizontalSpeed, rb.velocity.y);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag=="Respawn")
        {
            BallActive = false;
            gameManager.RespawnBall();
            ballDead.Play();
          

        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (ballBounce.isPlaying)
        {
            ballBounce.Stop();
            ballBounce.Play();
        }
        else
        {
            ballBounce.Play();
        }
        if (other.gameObject.tag == "brick")
        {
            gameManager.AddScore(points);
            // Destroy(other.gameObject);

            other.gameObject.GetComponent<brick>().DestroyBrick();
            if (ballBrick.isPlaying)
            {
                ballBrick.Stop();
                ballBrick.Play();
            }
            else
            {
                ballBrick.Play();
            }
        }

        if (other.gameObject.tag == "Base")
        {
            gameManager.AddScore(points/2);
            
            if (ballBounce.isPlaying)
            {
                ballBounce.Stop();
                ballBounce.Play();
            }
            else
            {
                ballBounce.Play();
            }
        }
    }

    public void ActivateBall()
    {
        BallActive = true;
        rb.velocity = new Vector2(Random.Range(-bounceForce, bounceForce), bounceForce);
    }
   
}
   