using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausedMenu : MonoBehaviour
{

    public GameObject StartUI, PauseMenu, Controlls;

    public void Pause()
    {
        Time.timeScale = 0;
        StartUI.SetActive(true);
        Controlls.SetActive(false);

    }

    public void Resume()
    {
        Time.timeScale = 1;
        StartUI.SetActive(false);
        Controlls.SetActive(true);
    }

}
