using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.Audio;

public class scoreforlevel3 : MonoBehaviour
{
    public static int currentscoreforlevel3 = 0;
    public Text Score3;
    public Text MaxScore3;


    // Use this for initialization
    void Start()
    {

        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        MaxScore3.text = PlayerPrefs.GetInt("Level3Score").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        Score3.text = "Score:" + currentscoreforlevel3;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score is > than the max
        if (currentscoreforlevel3 > PlayerPrefs.GetInt("Level3Score", 0))
        {
           // set the new max score to the current current score
            PlayerPrefs.SetInt("Level3Score", currentscoreforlevel3);
        }
    }
}