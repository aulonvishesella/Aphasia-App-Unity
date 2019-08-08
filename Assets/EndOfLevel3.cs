using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class EndOfLevel3 : MonoBehaviour {
    //declaration of 5 game objects
    public GameObject Obj01;
    public GameObject Obj02;
    public GameObject Obj03;
    public GameObject Obj04;
    public GameObject NextLevelPanel;



    void Start()
    {
        //at the start of the application the panel to go to the next level is set to false. Therefore not presented to the user.
        NextLevelPanel.SetActive(false);
    }

    public void Update()
    {
        //if all the objectives in the virtual world is set to false(i.e. not active)
        if (Obj01.active == false && Obj02.active == false && Obj03.active == false && Obj04.active == false)
        {
            //present the panel for the user to have an option to go to the next level.
            NextLevelPanel.SetActive(true);
        }
    }
    //function to go back to level 1
    public void Level1ButtonMethod()
    {
        //load scene level 01 and set the current score to zero
        SceneManager.LoadScene("Level01");
        scoreforlevel3.currentscoreforlevel3 = 0;
    }
    //function to go back to level 2
    public void Level2ButtonMethod()
    {
        //load level two and set the current scoee to zero
        SceneManager.LoadScene("Level02");
        scoreforlevel3.currentscoreforlevel3 = 0;
    }
    //function to reload level 3
    public void RestartLevel()
    {
        //reload level 3
        SceneManager.LoadScene("Level03");
        //set the current score for level 3 to zero 
        scoreforlevel3.currentscoreforlevel3 = 0;

    }
}
