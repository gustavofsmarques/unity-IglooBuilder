using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSound : MonoBehaviour
{

    public GameObject SoundUI, SoundPanel, play, credits, sound, extra, soundManager;




    public void Pause()
    {
       
        SoundUI.SetActive(true);
        credits.SetActive(false);
        sound.SetActive(false);
        extra.SetActive(false);
        play.SetActive(false);

    }

    public void Resume()
    {
        
        SoundUI.SetActive(false);
        play.SetActive(true);
        credits.SetActive(true);
        sound.SetActive(true);
        extra.SetActive(true);
       
    }

    public void Mute()
    {
        if (soundManager == null)
        {
            soundManager = GameObject.Find("SoundManager");
        }

        soundManager.SetActive(false);
        

    }

    public void DesMute()
    {
        if(soundManager == null)
        {
            SoundManager.instance.makeActive();
        }
        else
        {
            soundManager.SetActive(true);
        }

    }

}
