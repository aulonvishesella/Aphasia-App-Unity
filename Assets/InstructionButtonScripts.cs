using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionButtonScripts : MonoBehaviour {

    //loads the infromation scene
    public void InfromationButton()
    {
        //if the help button is pressed, load the scene 'Help'
        SceneManager.LoadScene("Information");

    }
    //loads the Main Menu scene
    public void MainMenuButton()
    {
        //if the help button is pressed, load the scene 'Help'
        SceneManager.LoadScene("MainMenu");

    }
}
