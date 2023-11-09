using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //variable
    public float speed;                 //control speed of movement
    float move;                         //control direction of Movement

    public float jump;

    public bool isJumping;

    Rigidbody2D rb;                     //store the rigidbody of an object



    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        jump = 400f;
        rb = GetComponent<Rigidbody2D>();            //get the rigidbody of the object
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");                                             //when any of the horizontal keys are pressed
        rb.velocity = new Vector2(speed * move, rb.velocity.y);                        //change the value of the rb to move


        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            Debug.Log("space");
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }






    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }


    }



}
