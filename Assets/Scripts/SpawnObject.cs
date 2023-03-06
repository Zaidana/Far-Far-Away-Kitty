using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    private Rigidbody2D Enemies;
    public float speed;
    
    void Start()
    {
        Enemies = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
       
        Enemies.velocity = Vector2.left * speed;
    }
}
