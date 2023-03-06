using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{

    bool gameEnded = false;
   public void EndGame ()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER");
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("Death");
    }
}
