using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class newlevel2 : MonoBehaviour {

    public GameObject Obj01;
    public GameObject Obj02;
    public GameObject Obj03;
    public GameObject Obj04;
    public GameObject LevelButton;
    public GameObject RestartLevelButton;
    public GameObject NextLevelPanel;
    void Start()
    {
        //when the game is loaded initially, the next level panel must be false
        NextLevelPanel.SetActive(false);
    }

    public void Update()
    {
        //if all the objectives are complete, load up the next level panel
        if (Obj01.active == false && Obj02.active == false && Obj03.active == false && Obj04.active == false)
        {
            NextLevelPanel.SetActive(true);
        }
    }
    //if button for button for next level is clicked on, go to level three.
    public void LevelButtonMethod()
    {
        SceneManager.LoadScene("Level03");
        scoreforlevel2.level2currentscore = 0;
    }
    //if the button for restart level button is clicked, restart the level and set the current score to zero.
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level02");
        scoreforlevel2.level2currentscore = 0;

    }
}
