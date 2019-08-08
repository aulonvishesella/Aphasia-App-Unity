using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseit2: MonoBehaviour
{
    public GameObject pausePanel;


    void Start()
    {
        //when the game is loaded, the pause panel is inactive
        pausePanel.SetActive(false);
    }

    //when the user pauses the game, set the panel true. 
    public void PauseTheGame()
    {
        //freezes the current game
        Time.timeScale = 0f;
        pausePanel.SetActive(true);

    }
    //if the user clicks 'play', resume where left off
    public void ResumeGame()
    {

        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    //if 'Quit' is pressed, reload the main menu
    //set the current score for level 2 to zero
    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
        scoreforlevel2.level2currentscore = 0;
        Time.timeScale = 1f;

    }
}