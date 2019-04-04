using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public GameObject[] iglooParts;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0 ; i < iglooParts.Length; i++)
        {
            if (score > i * 1) {
                iglooParts[i].SetActive(true);
            }
            
        }
    }
}
