using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class obj1score : MonoBehaviour {

    public static int scorerepeatobj1 = 0;
    public Text ScoreRepeatObj1;
    public Text MaxScoreObj1;

    // Use this for initialization
    void Start () {


        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk

        MaxScoreObj1.text = PlayerPrefs.GetInt("MaxScoreObj1").ToString();
    }
	
	// Update is called once per frame
	void Update () {
        ScoreRepeatObj1.text = "Score:" + scorerepeatobj1;
        //inspired from h/ttps://www.youtube.com/watch?v=vZU51tbgMXk
       //if the current score is greater than the max score for the object
        if (scorerepeatobj1 > PlayerPrefs.GetInt("MaxScoreObj1", 0))
        {
           //the maximum score is set to the current score for the repeat of object 1
            PlayerPrefs.SetInt("MaxScoreObj1", scorerepeatobj1);
        }
    }
}
