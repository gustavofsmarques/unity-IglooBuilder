using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    string name = "credits";
    public void ChangeScene()
    {
        SceneManager.LoadScene(name);
    }
}