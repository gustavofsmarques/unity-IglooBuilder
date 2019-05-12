using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausedMenu : MonoBehaviour
{

    public GameObject StartUI, PauseMenu, jumpbutton, stickmove, pause;

    public void Pause()
    {
        Time.timeScale = 0;
        StartUI.SetActive(true);
        pause.SetActive(false);
        stickmove.SetActive(false);
        jumpbutton.SetActive(false);


    }

    public void Resume()
    {
        Time.timeScale = 1;
        StartUI.SetActive(false);
        pause.SetActive(true);
        jumpbutton.SetActive(true);
        stickmove.SetActive(true);
    }

}
