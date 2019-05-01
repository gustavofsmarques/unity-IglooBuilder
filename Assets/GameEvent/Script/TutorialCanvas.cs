using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCanvas : MonoBehaviour
{
    
        public void NextPage(GameObject page)
    {
        gameObject.SetActive(false);
        page.SetActive(page);
    }
}
