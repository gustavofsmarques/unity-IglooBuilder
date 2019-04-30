using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class IglooPoint : MonoBehaviour
{

    [SerializeField] private string newLevel;
    private static int score = 0;
    public GameObject iglooEntry;
    public Text scoretxt;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
            score = score + 1;
        }
       
    }

    // Start is called before the first frame update
    void Start()
    {

    }
  
    // Update is called once per frame
    void Update()
    { 
        scoretxt.text = score.ToString();   
    }
    public void ResetScore()
    {
        score = 0;
    }
}
