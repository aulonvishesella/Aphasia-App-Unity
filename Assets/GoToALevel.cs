using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToALevel : MonoBehaviour {

    //method that starts level 1
    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level01");
        ScoreBoard.theCurrentScore = 0;
        scoreforlevel2.level2currentscore = 0;
        scoreforlevel3.currentscoreforlevel3 = 0;

    }
    //method that starts level 2
    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level02");
        ScoreBoard.theCurrentScore = 0;
        scoreforlevel2.level2currentscore = 0;
        scoreforlevel3.currentscoreforlevel3 = 0;
    }
    //method that starts level 3
    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level03");
        ScoreBoard.theCurrentScore = 0;
        scoreforlevel2.level2currentscore = 0;
        scoreforlevel3.currentscoreforlevel3 = 0;
    }
}
