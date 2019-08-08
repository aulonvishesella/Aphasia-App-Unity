using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object4RepeatLevel2 : MonoBehaviour
{

    public static int scorerepeatobj4L2 = 0;
    public Text ScoreRepeatObj4L2;
    public Text MaxScoreObj4L2;


    // Use this for initialization
    void Start()
    {
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        MaxScoreObj4L2.text = PlayerPrefs.GetInt("MaxScoreObj4L2").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        ScoreRepeatObj4L2.text = "Score:" + scorerepeatobj4L2;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score is greater than max score, set the max score as the current score
        if (scorerepeatobj4L2 > PlayerPrefs.GetInt("MaxScoreObj4L2", 0))
        {
            PlayerPrefs.SetInt("MaxScoreObj4L2", scorerepeatobj4L2);
        }
    }
}