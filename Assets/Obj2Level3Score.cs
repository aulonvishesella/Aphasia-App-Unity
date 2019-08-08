using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obj2Level3Score : MonoBehaviour
{

    public static int scorerepeatobj2L3 = 0;
    public Text ScoreRepeatObj2L3;
    public Text MaxScoreObj2L3;


    // Use this for initialization
    void Start()
    {

        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        MaxScoreObj2L3.text = PlayerPrefs.GetInt("MaxScoreObj2L3").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        ScoreRepeatObj2L3.text = "Score:" + scorerepeatobj2L3;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score greater than max score;max score is set to current score
        if (scorerepeatobj2L3 > PlayerPrefs.GetInt("MaxScoreObj2L3", 0))
        {


            PlayerPrefs.SetInt("MaxScoreObj2L3", scorerepeatobj2L3);
        }
    }
}