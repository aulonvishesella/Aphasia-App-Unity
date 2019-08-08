using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class obj4score : MonoBehaviour {
    public static int scorerepeatobj4 = 0;
    public Text ScoreRepeatObj4;
    public Text MaxScoreObj4;
    // Use this for initialization
    void Start () {
    
        MaxScoreObj4.text = PlayerPrefs.GetInt("MaxScoreObj4").ToString();
    }
	
	// Update is called once per frame
	void Update () {
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        ScoreRepeatObj4.text = "Score:" + scorerepeatobj4;

        //if the current score is greater than the max score for the object
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        if (scorerepeatobj4 > PlayerPrefs.GetInt("MaxScoreObj4", 0))
        {

            //the maximum score is set to the current score for the repeat of object 2
            PlayerPrefs.SetInt("MaxScoreObj4", scorerepeatobj4);
        }
    }
}