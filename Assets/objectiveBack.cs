using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objectiveBack : MonoBehaviour {

    public void BackButton()
    {
        //when the backbuton is clicked, it will load the main menu scene
        SceneManager.LoadScene("Help");
        Debug.Log("Loading Help");
    }

}
