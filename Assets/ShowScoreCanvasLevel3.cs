using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScoreCanvasLevel3 : MonoBehaviour
{
    public GameObject scorePanel;

 
    // Use this for initialization
    void Start()
    {
        //set score panel false when game loaded
        scorePanel.SetActive(false);
    }

    //function called when want to visit the stored results.
    public void SeeScore()
    {
        //set score panel to be shown and pause panel is set to false
        scorePanel.SetActive(true);
      
        Time.timeScale = 0f;
    }


    //function called when you want to play the game again
    public void ReturnToGame()
    {
        scorePanel.SetActive(false);
     
        Time.timeScale = 1f;
    }
}
