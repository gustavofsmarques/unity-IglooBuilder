using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cutscenes : MonoBehaviour
{
    public Text text;
    public void EndCutscene()
    {
        ManagementScene managementScene = new ManagementScene();
        managementScene.ChangeScene("menu");
    }
    public IEnumerator WriteText(string fulltext)
    {
        float delay = 0.030f;
        string currentext = "";
        text.text = "";

        for (int i = 0; i < fulltext.Length+1; i++)
        {
            currentext = fulltext.Substring(0, i);
            text.text = currentext;
            yield return new WaitForSeconds(delay);
        }

    }
}
