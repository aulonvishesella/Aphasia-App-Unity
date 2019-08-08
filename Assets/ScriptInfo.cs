using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptInfo : MonoBehaviour {

    public void MainMenuButton()
    {
       //when the backbuton is clicked, it will load the main menu scene
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Loading main menu");
    }

    public void HelpButton()
    {
        //when the aim button is clicked, it will load the objective scene
        SceneManager.LoadScene("Help");
    }
    public void InstructionsButton()
    {
        //when the aim button is clicked, it will load the objective scene
        SceneManager.LoadScene("Instructions");
    }


    public void ControlsButton()
    {
        //when the controls button is clicked, it will load the controls scene
        SceneManager.LoadScene("ControlScene");

    }
}
