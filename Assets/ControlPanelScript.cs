using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlPanelScript: MonoBehaviour {

    public void HelpButton()
    {
        //when the the help button is clicked, the help screen is loaded
        SceneManager.LoadScene("Help");
       
    }

    //when the main menu button is clicked, the main menu screen is loaded
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }



}
