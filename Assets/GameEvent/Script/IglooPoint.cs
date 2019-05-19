using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class IglooPoint : MonoBehaviour
{

    [SerializeField] private string newLevel;
    private static int score = 0;
    public GameObject iglooEntry;
    public GameObject RankingObj;
    public Text scoretxt;
    public GameObject lvlDay;
    public bool doingSetup;
    public Text dayscore;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && iglooEntry.activeSelf)
        {
            score = score + 1;
            lvlDay.SetActive(true);
            StartCoroutine(WaitForIt(3));

        }
        IEnumerator WaitForIt(float waitTime)
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(newLevel);
        }

    }

    void Update()
    {
        dayscore.text = score.ToString();
        scoretxt.text = score.ToString();   
    }
    public void ResetScore(Text player)
    {
        RankingObj.GetComponent<RankingController>().CheckForHighScore(score, player.text);
        score = 0;
    }
}
