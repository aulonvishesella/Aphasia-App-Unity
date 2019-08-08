using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obj3Level3Score : MonoBehaviour
{

    public static int scorerepeatobj3L3 = 0;
    public Text ScoreRepeatObj3L3;
    public Text MaxScoreObj3L3;


    // Use this for initialization
    void Start()
    {
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        MaxScoreObj3L3.text = PlayerPrefs.GetInt("MaxScoreObj3L3").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        ScoreRepeatObj3L3.text = "Score:" + scorerepeatobj3L3;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score greater than max score;max score is set to current score
        if (scorerepeatobj3L3 > PlayerPrefs.GetInt("MaxScoreObj3L3", 0))
        {


            PlayerPrefs.SetInt("MaxScoreObj3L3", scorerepeatobj3L3);
        }
    }
}