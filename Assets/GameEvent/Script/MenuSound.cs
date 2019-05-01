using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSound : MonoBehaviour
{

    public GameObject SoundUI, SoundPanel, play, credits, sound;

    public void Pause()
    {
       
        SoundUI.SetActive(true);
        play.SetActive(false);
        credits.SetActive(false);
        sound.SetActive(false);
    }

    public void Resume()
    {
        
        SoundUI.SetActive(false);
        play.SetActive(true);
        credits.SetActive(true);
        sound.SetActive(true);
    }

}
