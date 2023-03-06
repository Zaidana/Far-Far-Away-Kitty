using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public GameObject[] spawnObjects;
    public GameObject[] spawnPoints;
    public GameObject tunaCans;
    public GameObject[] spawnTuna;
    public float timer = 0;
    public TextMeshProUGUI textTimer;
    public TextMeshProUGUI scoreText;
    int score = 0;
    

    private void Awake()
    {
       instance = this;
    }
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        InvokeRepeating("InstanciarElementos", 0.5f, 5);
        InvokeRepeating("InstanciarTuna", 2f, 8);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        textTimer.text = "Time: " + timer.ToString("f0");
    }

    public void InstanciarElementos()
    {
            int randNum = Random.Range(0, 3);
            int randomNumObjects = Random.Range(0, spawnObjects.Length);
            GameObject objetoInstanciado = Instantiate(spawnObjects[randomNumObjects], spawnPoints[randNum].transform.position, Quaternion.identity);
        Destroy(objetoInstanciado, 8);
        }

    public void InstanciarTuna()
    {
        int randSpawnTuna = Random.Range(0, 3);
        GameObject TunaInstanciado = Instantiate(tunaCans, spawnTuna[randSpawnTuna].transform.position, Quaternion.identity);
        
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }

  
    }



