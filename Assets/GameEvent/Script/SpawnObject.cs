using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject snowBall;
    public GameObject platform;

    public float minPlatformSpaw;
    public float maxPlatformSpaw;
    public float minSnowBallSpaw;
    public float maxSnowBallSpaw;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnSnowBall()
    {
        //This is the bottom-left point of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        //This is the top-right point of the screen
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        //Instantiate an enemy
        GameObject anObject = (GameObject)Instantiate(snowBall);

        anObject.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);

        //Schedule when to spaen next enemy
        ScheduleNextSnowBallSpawn(maxSnowBallSpaw);
    }


    void SpawnPlatform()
    {
        //This is the bottom-left point of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        //This is the top-right point of the screen
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 0.5f));

        //Instantiate an enemy
        GameObject anObject = (GameObject)Instantiate(platform);

        anObject.transform.position = new Vector2(max.x, Random.Range(min.y, max.y));

        //Schedule when to spaen next enemy
        ScheduleNextPlatformSpawn(maxPlatformSpaw);
    }

    void ScheduleNextSnowBallSpawn(float maxSpawnInSeconds)
    {
        float spawnInNSeconds;

        if (maxSpawnInSeconds > minSnowBallSpaw)
        {
            //pixk a number between 3 and maxSpawnRateInSeconds
            spawnInNSeconds = Random.Range(minSnowBallSpaw, maxSpawnInSeconds);
        }
        else
        {
            spawnInNSeconds = minSnowBallSpaw;
        }
        Invoke("SpawnSnowBall", spawnInNSeconds);
    }

    void ScheduleNextPlatformSpawn(float maxSpawnInSeconds)
    {
        float spawnInNSeconds;

        if (maxSpawnInSeconds > minPlatformSpaw)
        {
            //pixk a number between 1 and maxSpawnRateInSeconds
            spawnInNSeconds = Random.Range(minPlatformSpaw, maxSpawnInSeconds);
        }
        else
        {
            spawnInNSeconds = minPlatformSpaw;
        }
        Invoke("SpawnPlatform", spawnInNSeconds);
    }


    //Function to start enemy spawner
    public void ScheduleObjectSpawner()
    {

        Invoke("SpawnSnowBall", maxSnowBallSpaw);
        Invoke("SpawnPlatform", maxPlatformSpaw);

    }

}
