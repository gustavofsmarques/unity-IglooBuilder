using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objectSpawner;//reference to our enemy spawner 


    // Start is called before the first frame update
    void Start()
    {
        objectSpawner.GetComponent<SpawnObject>().ScheduleObjectSpawner();

    }

    // Update is called once per frame
    void Update()
    {
        //start enemy spawner
       

    }

   
}
