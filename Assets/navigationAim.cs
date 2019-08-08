using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class navigationAim : MonoBehaviour {

    public void clickMainMenu()
    {
        //when the button is click, the pause screen is shown.
        SceneManager.LoadScene("MainMenu");

    }

    public void clickHelpMenu()
    {
        //when the button is click, the pause screen is shown.
        SceneManager.LoadScene("Help");

    }
}
