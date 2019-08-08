using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {
   
    //method that starts level 1
    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level01");

    }
    //method that starts level 2
    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level02");

    }
    //method that starts level 3
    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level03");

    }
    //quit the application
    public void QuitButton()
    {
        //if the 'Quit' button is pressed - quit the application
        Application.Quit();
       
    }
    //loads the infromation scene
    public void InfromationButton()
    {
        //if the help button is pressed, load the scene 'Help'
        SceneManager.LoadScene("Information");
       
    }
	// Update is called once per frame
	public void Update () {
		 
	}
}
