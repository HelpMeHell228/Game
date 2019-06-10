using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour {

    public Rigidbody2D rb;
    public float moveSpeed;
    public float flapHeight;


    // Use this for initialization
    void Start () { 
        rb = GetComponent<Rigidbody2D>();
    }
  
       // Update is called once per frame
       void Update () {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, flapHeight);
        }

        if (transform.position.y > 18 || transform.position.y < -19)
        {
            Death();
        }

    }

    public void Death()
    {
        SceneManager.LoadScene(0);
    }

}