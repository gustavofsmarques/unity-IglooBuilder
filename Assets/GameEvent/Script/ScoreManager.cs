using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public GameObject[] iglooParts;
    public int score = 0;
    public GameObject ready;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0 ; i <= iglooParts.Length; i++)
        {
            if (score > i && score <= i)
            {
                iglooParts[i].SetActive(true);
            }  
        }
        if(score >= iglooParts.Length)
        {
            ready.SetActive(true);
        }
        
    }


}
