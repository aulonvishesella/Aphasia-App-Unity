using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class repeatobj2level1 : MonoBehaviour
{

    public static int scorerepeatobj2 = 0;
    public Text ScoreRepeatObj2;
    public Text MaxScoreObj2;


    // Use this for initialization
    void Start()
    {
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        MaxScoreObj2.text = PlayerPrefs.GetInt("MaxScoreObj2").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        ScoreRepeatObj2.text = "Score:" + scorerepeatobj2;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score is greater than the max score for the object
        if (scorerepeatobj2 > PlayerPrefs.GetInt("MaxScoreObj2", 0))
        {

            //the maximum score is set to the current score for the repeat of object 2

            PlayerPrefs.SetInt("MaxScoreObj2", scorerepeatobj2);
        }
    }
}