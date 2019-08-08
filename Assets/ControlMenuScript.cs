using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlMenuScript : MonoBehaviour {

    public void MainMenuButton()
    {
        //return to the main menu
        SceneManager.LoadScene("MainMenu");
    }


    public void InformationButton()
    {
        //return to the information screen
        SceneManager.LoadScene("Information");

    }
}
