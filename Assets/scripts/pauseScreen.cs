using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pauseScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resumeGame()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);

    }
    public void QuitToMainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainmenuScene");
    }

      public void QuitApp()
        {
        //Time.timeScale = 1f;
        Application.Quit();
        }

    }
