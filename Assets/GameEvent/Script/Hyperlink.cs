using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperlink : MonoBehaviour
{
    private readonly string urlfacebook = "https://www.facebook.com/unicluster.face";
    private readonly string urltwitter = "https://twitter.com/unicluster";
    private readonly string urlmoodle = "http://blog.unicluster.com.br/";
    public string urloption;
    public void OpenLink()
    {
        var url = "";

        if(urloption == "facebook")
        {
            url = urlfacebook;
        }
        else if(urloption == "twitter")
        {
            url = urltwitter;
        }
        else if(urloption == "moodle")
        {
            url = urlmoodle;
        }
        Application.OpenURL(url);
    } 
}
