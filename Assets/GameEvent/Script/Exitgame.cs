using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exitgame : MonoBehaviour
{
    

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
