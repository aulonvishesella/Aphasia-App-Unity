using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object2RepeatLevel2 : MonoBehaviour
{

    public static int scorerepeatobj2L2 = 0;
    public Text ScoreRepeatObj2L2;
    public Text MaxScoreObj2L2;


    // Use this for initialization
    void Start()
    {
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
  
        MaxScoreObj2L2.text = PlayerPrefs.GetInt("MaxScoreObj2L2").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //the score text is the text score with the current score value
        ScoreRepeatObj2L2.text = "Score:" + scorerepeatobj2L2;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score is greater than max score, set the max score as the current score
        if (scorerepeatobj2L2 > PlayerPrefs.GetInt("MaxScoreObj2L2", 0))
        {


            PlayerPrefs.SetInt("MaxScoreObj2L2", scorerepeatobj2L2);
        }
    }
}