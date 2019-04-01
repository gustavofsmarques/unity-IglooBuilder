using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool verifica = true;
    Rigidbody2D myRB;

    // Start is called before the first frame update
    void Start()
    {
        
        myRB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && verifica == true)
        {

            myRB.AddForce(new Vector2(0, 400));


        }

    }


    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("plataforma"))
        {
            verifica = true;
        }


    }
    void OnCollisionExit2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("plataforma"))
        {
            verifica = false;
        }
    }
}