using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object3RepeatLevel2 : MonoBehaviour
{

    public static int scorerepeatobj3L2 = 0;
    public Text ScoreRepeatObj3L2;
    public Text MaxScoreObj3L2;


    // Use this for initialization
    void Start()
    {
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        MaxScoreObj3L2.text = PlayerPrefs.GetInt("MaxScoreObj3L2").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        ScoreRepeatObj3L2.text = "Score:" + scorerepeatobj3L2;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score is greater than max score, set the max score as the current score
        if (scorerepeatobj3L2 > PlayerPrefs.GetInt("MaxScoreObj3L2", 0))
        {


            PlayerPrefs.SetInt("MaxScoreObj3L2", scorerepeatobj3L2);
        }
    }
}