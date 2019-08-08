using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score2Controller : MonoBehaviour {
    public GameObject scorePanel;
 
    // score panel is false when the application is loaded
    void Start()
    {
        scorePanel.SetActive(false);
    }

    //this button will allow the score panel to be loaded and the pause panel to be inactive.
    public void SeeScore()
    {
        scorePanel.SetActive(true);
    
        Time.timeScale = 0f;
    }

    //closes the stored results and resumes the game.
    public void ReturnToGame()
    {
        scorePanel.SetActive(false);
      
        Time.timeScale = 1f;
    }
}
