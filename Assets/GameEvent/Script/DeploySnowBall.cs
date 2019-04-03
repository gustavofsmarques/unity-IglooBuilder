using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeploySnowBall : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject snowBallPrefab;
    public float respawnTime = 2.0f;
    private Vector2 screenbounds;
    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-respawnTime, 0);
       screenbounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
    private void respawnEnemy()
    {
        GameObject snow = Instantiate(snowBallPrefab) as GameObject;
        snow.transform.position = new Vector2(screenbounds.y * -2, Random.Range(-screenbounds.y, screenbounds.y));
        

    }
    
    IEnumerator snow()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            respawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
