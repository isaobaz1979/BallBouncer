using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    


    public Text lifeText;
    public Text scoreText;

    public Text HiScoreText;
   
    public  int HiScore;
    public int lives;
    public int Score;


    public bool gameActive;
    private Ball theBall;


    public Button PauseButton;
    public Button launchBall;

   public GameObject pauseScreen;

   // public brick brickCheck;
    




    public GameObject levelComplete;


    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        
        theBall = FindObjectOfType<Ball>();

        Score = PlayerPrefs.GetInt("Score");

        lives = PlayerPrefs.GetInt("Lives");

        lifeText.text = "Lives left:  " + lives;
        scoreText.text = "Score: " + Score;





        HiScore = PlayerPrefs.GetInt("HiScore");
       // lifeText.text = "Lives left: " + lives;

        //CurrentHiScore = PlayerPrefs.GetInt("CurrentScores");
        HiScoreText.text = "Hi-Score: " + HiScore;






    }

    // Update is called once per frame
    void Update()
    {

        var brickCheck = FindObjectOfType<brick>();


        if (brickCheck == null)
        {
            levelComplete.SetActive(true);
            Time.timeScale = 0f;
        }



        if (Input.GetButtonDown("launchBall") && !gameActive)
        {
            theBall.ActivateBall();
            gameActive = true;
            
   

        }

        if (Input.GetButtonDown("PauseButton")&& gameActive)
        {
            if (pauseScreen.activeSelf)
            {
                Time.timeScale = 1f;
                pauseScreen.SetActive(false);
                gameActive = false;


            }
            else
            {
                Time.timeScale = 0f;
                pauseScreen.SetActive(true);

            }
        }

       
        

       

      
    }

   

   
    public void RespawnBall()
    {
        gameActive = false;
        lives -= 1;
        if (lives < 0)
        {
            theBall.gameObject.SetActive(false);
            gameOverScreen.SetActive(true);
            lifeText.text = "All lives lost";
            PlayerPrefs.SetInt("HiScore", HiScore);

        }
        else
        {
            lifeText.text = "Lives left:  " + lives;
           
        }
        //PlayerPrefs.SetInt("Lives", lives);
    }

    public void AddScore(int scoreToAdd)
    {
        Score =Score+ scoreToAdd;
        scoreText.text = "Score:  " + Score;

        if (Score > HiScore)
        {
            HiScore = Score;
            HiScoreText.text = "Hi-Score: " + HiScore;
        }

        
    }


    

}
