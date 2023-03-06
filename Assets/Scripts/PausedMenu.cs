using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    public GameObject gamePaused;
    public GameObject PauseButton;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        gamePaused.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        gamePaused.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0f;
            
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        gamePaused.SetActive(false);
        PauseButton.SetActive(true);
        
        
        
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartPage");
    }

   public void QuitGame()
    {
        Application.Quit();
    }
}
