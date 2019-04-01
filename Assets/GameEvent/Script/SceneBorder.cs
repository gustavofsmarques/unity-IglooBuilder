using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBorder : MonoBehaviour
{

    public GameObject otherBorder;
    public bool isRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (isRight)
            {
                collision.gameObject.transform.position = new Vector2(otherBorder.transform.position.x + 2f, collision.gameObject.transform.position.y);
            }
            else
            {
                collision.gameObject.transform.position = new Vector2(otherBorder.transform.position.x - 2f, collision.gameObject.transform.position.y);
            }
            
        }
    }
}
