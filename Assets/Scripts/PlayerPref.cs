using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPref : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI inputScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePlayerPref()
    {
        PlayerPrefs.SetInt("Score",inputScore);
    }

    public void PrintPlayerPref()
    {
        playerScore = PlayerPrefs.GetInt("Score");
    }
}
