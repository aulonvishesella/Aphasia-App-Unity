using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object1RepeatLevel2 : MonoBehaviour
{

    public static int scorerepeatobj1L2 = 0;
    public Text ScoreRepeatObj1L2;
    public Text MaxScoreObj1L2;


    // Use this for initialization
    void Start()
    {

        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        MaxScoreObj1L2.text = PlayerPrefs.GetInt("MaxScoreObj1L2").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        ScoreRepeatObj1L2.text = "Score:" + scorerepeatobj1L2;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score is greater than max score, set the max score as the current score
        if (scorerepeatobj1L2 > PlayerPrefs.GetInt("MaxScoreObj1L2", 0))
        {
            PlayerPrefs.SetInt("MaxScoreObj1L2", scorerepeatobj1L2);
        }
    }
}