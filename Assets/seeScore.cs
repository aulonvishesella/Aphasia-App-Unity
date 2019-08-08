using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seeScore : MonoBehaviour {
    public GameObject scorePanel;

    // Use this for initialization
    void Start () {
        scorePanel.SetActive(false);
	}
	
    //this operation allows the user to visit the stored results panel.called when the user clicks on 'stored results' button from the pause panel.
	public void SeeScore()
    {
        //show score panel

    
        scorePanel.SetActive(true);
        //hide pause panel
    
        Time.timeScale = 0f;
    }
    
    //this operation is called inside the game when the button 'Play' is pressed. This resumes the game.
    public void ReturnToGame()
    {
        //hide score panel
        scorePanel.SetActive(false);
        
        //hide pause panel
      
        Time.timeScale = 1f;
    }


}
