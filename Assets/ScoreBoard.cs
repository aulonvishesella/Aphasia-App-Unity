using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//ttps://www.youtube.com/watch?v=QbqnDbexrCw
public class ScoreBoard: MonoBehaviour {

    public static int theCurrentScore = 0;
    public Text Score;
    public Text MaxScore;


	// Use this for initialization
	void Start () {

        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        
        MaxScore.text = PlayerPrefs.GetInt("MaxScore").ToString();

    }
	
	// Update is called once per frame
	void Update () {
        Score.text = "Score:" + theCurrentScore;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
        //if the current score is greater than the max score
        if (theCurrentScore> PlayerPrefs.GetInt("MaxScore",0))
        {
            //the maximum score is the current score
            PlayerPrefs.SetInt("MaxScore", theCurrentScore);
        }
	}
}
