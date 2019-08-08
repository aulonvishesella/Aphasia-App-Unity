using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CommandControlScript : MonoBehaviour {

    // Use this for initialization
    public void HelpButton()
    {
        //if the play button is pressed, load the scene 'LEVEL01'

        SceneManager.LoadScene("Help");
      
    }

    public void QuitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
