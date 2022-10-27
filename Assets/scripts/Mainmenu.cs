using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mainmenu : MonoBehaviour
{

   

    public string firstLevel;


   
   public void NewGame() { 
   
        SceneManager.LoadScene(firstLevel);
       PlayerPrefs.SetInt("Score", 0);
       PlayerPrefs.SetInt("Lives", 3);


        if (!PlayerPrefs.HasKey("HiScore"))
        {
            PlayerPrefs.SetInt("HiScore", 0);

        }


    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
