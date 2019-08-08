using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obj3score : MonoBehaviour {


    public static int scorerepeatobj3 = 0;
    public Text ScoreRepeatObj3;
    public Text MaxScoreObj3;


    void Start()
    {

        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        MaxScoreObj3.text = PlayerPrefs.GetInt("MaxScoreObj3").ToString();
    }


    void Update()
    {
        ScoreRepeatObj3.text = "Score:" + scorerepeatobj3;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score is greater than the max score for the object
        if (scorerepeatobj3 > PlayerPrefs.GetInt("MaxScoreObj3", 0))
        {

            //the maximum score is set to the current score for the repeat of object 2

            PlayerPrefs.SetInt("MaxScoreObj3", scorerepeatobj3);
        }
    }
}
