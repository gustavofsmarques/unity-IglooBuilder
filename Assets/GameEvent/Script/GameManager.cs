using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject snowBall;
    private Vector3 snowBallPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        StartCoroutine("CreatwSnowBall", 2.0f);
    }

    IEnumerator CreatwSnowBall()
    {
        yield return new WaitForSeconds(1);
        float x = Random.Range(-50f, 50f);
        float y = 30f;
        snowBallPos = new Vector3(x, y, 0f);
        Instantiate(snowBall, snowBallPos, Quaternion.identity);
    }
}
