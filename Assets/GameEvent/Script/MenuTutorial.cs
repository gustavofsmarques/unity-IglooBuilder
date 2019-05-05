using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuTutorial : MonoBehaviour
{
    public GameObject play, sound, credits, extra, tutorialPanel;

    public void enterInfo()
    {
        tutorialPanel.SetActive(true);
        play.SetActive(false);
        sound.SetActive(false);
        credits.SetActive(false);
        extra.SetActive(false);
            
    }

    public void backInfo()
    {
        tutorialPanel.SetActive(false);
        play.SetActive(true);
        sound.SetActive(true);
        credits.SetActive(true);
        extra.SetActive(true);

    }

}
