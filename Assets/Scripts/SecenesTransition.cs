using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using System.Diagnostics;
using UnityEngine.SceneManagement;


public class SecenesTransition : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("StartPage");

    }

    public void MainMenuBack()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

  
