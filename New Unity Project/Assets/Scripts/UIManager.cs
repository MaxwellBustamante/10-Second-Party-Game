using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text ScoreText;
    public Text TimeText;
    public string ScorePrefix;
    public string TimePrefix;
    public float CurrentTime;
    public Player GetScore;


    void Update()
    {
        if(GameManager.AnnouncementFinish == false)
        {
            return;
        }

        ScoreText.text = ScorePrefix + GetScore.Score.ToString();
        CurrentTime += Time.deltaTime;
        TimeText.text = TimePrefix + CurrentTime.ToString("F1");


    }
}
