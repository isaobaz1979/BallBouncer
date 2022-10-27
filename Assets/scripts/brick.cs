using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{

    public int brickValue;
    private gameManager gameManager;
    


    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void DestroyBrick()
    {
        gameManager.AddScore(brickValue);
        Destroy(gameObject);
    }
}
