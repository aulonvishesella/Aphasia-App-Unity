using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitToMain : MonoBehaviour {

    //allows the user to return to the main menu.
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        ScoreBoard.theCurrentScore = 0;

    }
}
