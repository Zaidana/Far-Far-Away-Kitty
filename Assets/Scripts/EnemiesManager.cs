using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
   
    private void OnTriggerEnter2D (Collider2D collision)  
    {
        if(collision.gameObject.name=="Player")
        {
            Destroy(collision.gameObject);
            FindObjectOfType<DeathScreen>().EndGame();
            
        }
    }
}
