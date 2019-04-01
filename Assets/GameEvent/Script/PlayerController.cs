using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movemente Variable
    
    public float maxSpeed;


    //Jump Variable
    bool grounded = false;
    float groundCheckRadius = 0.2f;

    Rigidbody2D myRB;
    Animator myAnimTD;
    bool facingRight;

    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpHeight;


    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnimTD = GetComponent<Animator>();

        facingRight = true;
    }


    void Update()
    {
        
        if (grounded && Input.GetAxis("Jump") > 0)
        {

            grounded = false;

            myAnimTD.SetBool("isGrounded", false);
            myRB.AddForce(new Vector2(0, jumpHeight));

        }

    }


    // Update is called once per frame
    void FixedUpdate()
    {


        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        myAnimTD.SetBool("isGrounded", grounded);

        myAnimTD.SetFloat("verticalSpeed", myRB.velocity.y);


        float move = Input.GetAxis("Horizontal");
        myAnimTD.SetFloat("speed", Mathf.Abs(move));

        myRB.velocity = new Vector2(move * maxSpeed, myRB.velocity.y);

        if (move > 0 && !facingRight)

        {

            flip();

        }

        else if (move < 0 && facingRight)

        {

            flip();




        }



        void flip()
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            transform.localScale = theScale;
            theScale.x *= -1;
            transform.localScale = theScale;

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform;
        }

    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }

    }
}
