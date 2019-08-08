using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class objectiveController : MonoBehaviour
{

    //the controller has a list of objectives
    public TypeObjective[] objectives;
    GameObject objective;
    public Text text;

    void Start()
    {
    }

    //to show the image, we use the name and we call in the name into the image from the class (ImageController). - Then use the operation it has - ShowImage
    public void showImage(String name)
    {
        FindObjectOfType<ImageController>().ShowImage(name);
    }


    //to hide the image, we use the name and we call in the name into the image from the class (ImageController). Then use the operation it has - HideImage
    public void hideImage(String name)
    {
        FindObjectOfType<ImageController>().HideImage(name);
    }
    //to play the audio, we use the name and we call in the name into the audio from the class (AudioManager). We then use the operation it has 'AudioStart'
    public void playAudio(String name)
    {

        FindObjectOfType<AudioManager>().AudioStart(name);

    }
    //to stop the audio, we use the name and we call in the name into the audio from the class (AudioManager). We then use the operation it has 'mute'
    public void stopAudio(String name)
    {

        FindObjectOfType<AudioManager>().Mute(name);

    }




    //This is used to set a particular objective to false from the list of objective. You find a particular objective by passing in a paramater 'name' of type String
    public void GetObjectToHide(String name)
    {
        //for all the objectives added
        for (int i = 0; i < objectives.Length; i++)
        {
            //if the type of objective is equal to the name provided    
            if (objectives[i].typeOfObjective == name)
            {
                //set that specific objective to false
                objectives[i].objective.SetActive(false);


            }

        }
    }
    //calculate the distance between an objective and player.
    public GameObject RetrieveObjective(String name)
    {
        //for all the objectives added
        for (int i = 0; i < objectives.Length; i++)
        {
            //if there is an objective to name provided
            if (objectives[i].typeOfObjective == name)
            {
                //set that objective to the objective from the name provided.
                objective = objectives[i].objective;

            }


        }

        //return that particular objective
        return objective;
    }

    //sets the text used in the controller class for each level to the paramater passed.
    public String RetrieveName(String name)
    {
        //for all the objectives added
        for (int i = 0; i < objectives.Length; i++)
        {
            //if the type of objective is equal to the name provided
            if (objectives[i].typeOfObjective == name)
            {

                //set the text to that name
                text.text = objectives[i].wordOfObjective;

            }


        }
        return text.text;
    }



}






