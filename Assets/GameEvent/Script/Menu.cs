using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private string name = "menu";

    public void ChangeScene()
    {
        SceneManager.LoadScene(name);
    }
}
