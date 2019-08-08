using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level2ReturnToMainMenu : MonoBehaviour {
    
    public void returnMain()
    {
        SceneManager.LoadScene("MainMenu");
      
        scoreforlevel2.level2currentscore = 0;
    }
}
