using UnityEngine;
using UnityEngine.SceneManagement;



public class ManagementScene : MonoBehaviour
{

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

