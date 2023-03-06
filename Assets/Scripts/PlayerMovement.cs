using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float jump;
    private Rigidbody2D rb;
    private bool isGrounded;
    private bool smack;
    public int score;
   

    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            
            rb.AddForce(Vector2.up * jump);
            
           
        }

        if (Input.GetKeyDown(KeyCode.D) &&  !smack) 
        { 
            rb.AddForce(new Vector3 (3, 0, 0));
            if (transform.position.x <= -3.33f)
            {
                rb.AddForce(new Vector3(5, 0, 0), ForceMode2D.Force);
                transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -3.33f, -21), transform.position.y, transform.position.z);
            }

        }

        if (rb.transform.position.x < -20)
        {
            FindObjectOfType<DeathScreen>().EndGame();
        }


    }

    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("Jumping", false);
        }

        if(other.gameObject.CompareTag("Obstacle"))
        {
            smack = true;
            animator.SetBool("Smash", true);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            animator.SetBool("Jumping", true);
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            smack = false;
            animator.SetBool("Smash", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("TunaCan"))
        {
            Destroy(other.gameObject);  
            GameManager.instance.AddPoint();
        }
    }

    
}
