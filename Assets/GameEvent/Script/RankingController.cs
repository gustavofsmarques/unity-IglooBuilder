using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class RankingController : MonoBehaviour
{

    public Text[] highScores;
    public Text[] names;
    private int[] highScoreValues;
    private string[] highScoreNames;

    public void Start()
    {
        highScoreValues = new int[highScores.Length];
        highScoreNames = new string[highScores.Length];

        for (int x = 0; x < highScores.Length; x++)
        {
            highScoreValues[x] = PlayerPrefs.GetInt("highScoresValues" + x);
            highScoreNames[x] = PlayerPrefs.GetString("highScoresNames" + x);
        }
        if (highScores[0] != null)
        {
            DrawScores();
        }

    }

    public void SaveScores()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            PlayerPrefs.SetInt("highScoresValues" + x, highScoreValues[x]);
            PlayerPrefs.SetString("highScoresNames" + x, highScoreNames[x]);
        }
    }

    public void CheckForHighScore(int _value, string _userName)
    {
        if (string.IsNullOrEmpty(_userName))
        {
            _userName = "Player";
        }
        for (int x = 0; x < highScores.Length; x++)
        {
            if (_value > highScoreValues[x])
            {
                for (int y = highScores.Length - 1; y > x; y--)
                {
                    highScoreValues[y] = highScoreValues[y - 1];
                    highScoreNames[y] = highScoreNames[y - 1];
                }
                highScoreValues[x] = _value;
                highScoreNames[x] = _userName;

                SaveScores();
                break;
            }
        }
    }

    public void DrawScores()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            if(highScoreValues[x] > 0)
            {
                highScores[x].text = highScoreValues[x].ToString();
                names[x].text = highScoreNames[x];
            }
        }
    }

}