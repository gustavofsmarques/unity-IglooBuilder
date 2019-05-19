using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtraScript : MonoBehaviour
{
    public GameObject painel, back, frostyB, zoeB, play, config, extra, painelop, title,exit;

    public void onEnable()
    {
        
        frostyB.SetActive(true);
        zoeB.SetActive(true);
        play.SetActive(false);
        config.SetActive(false);
        extra.SetActive(false);
        back.SetActive(true);
        painel.SetActive(true);
        title.SetActive(true);
        painelop.SetActive(false);
        

    }

    public void onDisAble()
    {

        frostyB.SetActive(false);
        zoeB.SetActive(false);
        play.SetActive(true);
        config.SetActive(true);
        extra.SetActive(true);
        back.SetActive(false);
        painel.SetActive(false);
        exit.SetActive(true);
    }

}
