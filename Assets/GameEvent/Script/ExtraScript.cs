using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtraScript : MonoBehaviour
{
    public GameObject painel, back, frostyB, zoeB, play, credits, sound, extra;

    public void onEnable()
    {
        
        frostyB.SetActive(true);
        zoeB.SetActive(true);
        play.SetActive(false);
        credits.SetActive(false);
        sound.SetActive(false);
        extra.SetActive(false);
        back.SetActive(true);
        painel.SetActive(true);

    }

    public void onDisAble()
    {

        frostyB.SetActive(false);
        zoeB.SetActive(false);
        play.SetActive(true);
        credits.SetActive(true);
        sound.SetActive(true);
        extra.SetActive(true);
        back.SetActive(false);
        painel.SetActive(false);
    }

}
