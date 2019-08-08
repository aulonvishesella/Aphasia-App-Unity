
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.Audio;

public class scoreforlevel2 : MonoBehaviour
{
    public static int level2currentscore = 0;
    public Text Score2;
    public Text MaxScore2;


    // Use this for initialization
    void Start()
    {
      
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        MaxScore2.text = PlayerPrefs.GetInt("Level2Score").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //the score text is the text score with the current score value
        Score2.text = "Score:" + level2currentscore;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score is greater than max score, set the max score as the current score
        if (level2currentscore > PlayerPrefs.GetInt("Level2Score"  , 0))
        {

            PlayerPrefs.SetInt("Level2Score", level2currentscore);
        }
    }
}
