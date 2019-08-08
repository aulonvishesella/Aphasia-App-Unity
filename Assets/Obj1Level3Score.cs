using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obj1Level3Score : MonoBehaviour
{

    public static int scorerepeatobj1L3 = 0;
    public Text ScoreRepeatObj1L3;
    public Text MaxScoreObj1L3;


    // Use this for initialization
    void Start()
    {
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        MaxScoreObj1L3.text = PlayerPrefs.GetInt("MaxScoreObj1L3").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        ScoreRepeatObj1L3.text = "Score:" + scorerepeatobj1L3;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score greater than max score;max score is set to current score

        if (scorerepeatobj1L3 > PlayerPrefs.GetInt("MaxScoreObj1L3", 0))
        {


            PlayerPrefs.SetInt("MaxScoreObj1L3", scorerepeatobj1L3);
        }
    }
}