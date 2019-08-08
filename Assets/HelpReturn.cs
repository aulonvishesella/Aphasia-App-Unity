using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpReturn : MonoBehaviour {

    public void returnMain()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void returnToInformation()
    {
        SceneManager.LoadScene("Information");

    }
}
