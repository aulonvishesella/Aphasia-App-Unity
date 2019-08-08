using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obj4Level3Score : MonoBehaviour
{

    public static int scorerepeatobj4L3 = 0;
    public Text ScoreRepeatObj4L3;
    public Text MaxScoreObj4L3;


    // Use this for initialization
    void Start()
    {
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        MaxScoreObj4L3.text = PlayerPrefs.GetInt("MaxScoreObj4L3").ToString();


    }

    // Update is called once per frame
    void Update()
    {
        ScoreRepeatObj4L3.text = "Score:" + scorerepeatobj4L3;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score greater than max score;max score is set to current score
        if (scorerepeatobj4L3 > PlayerPrefs.GetInt("MaxScoreObj4L3", 0))
        {


            PlayerPrefs.SetInt("MaxScoreObj4L3", scorerepeatobj4L3);
        }
    }
}