using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour {

	public void ClickButton()
    {
        //when the button is click, the pause screen is shown.
        SceneManager.LoadScene("PauseScene");
    }
}
