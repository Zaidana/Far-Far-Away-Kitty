using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectables : MonoBehaviour
{
    private Rigidbody2D tunaCan;
    public float speed;

    void Start()
    {
        tunaCan = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        tunaCan.velocity = Vector2.left * speed;
    }
}
