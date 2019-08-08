using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseit3 : MonoBehaviour
{
    //pause panel is a game object
    public GameObject pausePanel;


    void Start()
    {
        //pause panel not seen when game loaded
        pausePanel.SetActive(false);
    }

    // function which pauses the game
    public void PauseTheGame()
    {
        //pause panel is shown
        Time.timeScale = 0f;
        pausePanel.SetActive(true);

    }
    //function which resumes the game
    public void ResumeGame()
    {
        //pause panel is deactivated
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    //function to quit the game
    public void QuitGame()
    {
        //load the main menu and set current score back to zero.
        SceneManager.LoadScene("MainMenu");
        scoreforlevel3.currentscoreforlevel3 = 0;
        Time.timeScale = 1f;

    }
}