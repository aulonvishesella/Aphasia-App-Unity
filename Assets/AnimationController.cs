using UnityEngine.Audio;
using UnityEngine;
using System;

public class AnimationController : MonoBehaviour {
    //an animation controller has a set of animations for objective(ring and cirlce)
    public AnimationForObjective[] animationForObjective;

    //function to hide the animation for objectives based on the objective type provided
    public void AnimationHide(string objectiveType)
    {
        //for loop until the max number of animation objectives in the array
        for (int i = 0; i < animationForObjective.Length; i++)
        {
            //if the objective type specified is equal to a type of animation from the array
            if (animationForObjective[i].typeOfAnimation == objectiveType)
            {
                //hide both the ring and arrow for that objective
                animationForObjective[i].ringAnimation.SetActive(false);
                animationForObjective[i].arrowAnimation.SetActive(false);
            }
        }
    }
}
