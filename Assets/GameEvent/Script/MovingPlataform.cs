using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlataform : MonoBehaviour{


    private float moveSpeed ;
    private Vector3 movement;




    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = Random.Range(1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
