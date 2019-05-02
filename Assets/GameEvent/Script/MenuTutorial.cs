using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuTutorial : MonoBehaviour
{
    public GameObject buttonplay, buttoninfo,credits,info,sound,infopainel;

    public void disableinfo( )
    {
        buttonplay.SetActive(true);
        buttoninfo.SetActive(false);
    }

    public void enableinfo( )
    {

        buttonplay.SetActive(false);
        buttoninfo.SetActive(true);


    }

    public void backInfo()
    {
        buttonplay.SetActive(false);
        buttoninfo.SetActive(false);
        credits.SetActive(true);
        sound.SetActive(true);
        info.SetActive(true);
        infopainel.SetActive(false);
       
    }

}
