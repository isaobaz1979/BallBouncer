using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverScreen : MonoBehaviour
{

    public int Score,Lives
        ;
    private gameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<gameManager>();
    }

    public void RestartLevel() {
     Score=0;
        Lives=3;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
public void QuitMain()
    {
        SceneManager.LoadScene("MainmenuScene");
    }






   }