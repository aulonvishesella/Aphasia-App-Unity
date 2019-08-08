using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level3ReturnToMainMenu : MonoBehaviour
{

    public void returnMain()
    {
        SceneManager.LoadScene("MainMenu");
        scoreforlevel3.currentscoreforlevel3 = 0;


    }
}
