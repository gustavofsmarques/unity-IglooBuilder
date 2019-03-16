using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    private new readonly string name = "credits";
    public void ChangeScene()
    {
        SceneManager.LoadScene(name);
    }
}