using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;
public class LonnyTalk : MonoBehaviour {
    CharacterController controllerLonny;
    Animator animationLonny;
    public int count = 0;
    // Use this for initialization
    void Start () {
        controllerLonny = GetComponent<CharacterController>();
        //retrieve the animations set for the avatar 'lonny'.
        animationLonny = GetComponent<Animator>();
    }
    //starts initally as idle
    void FixedUpdate()
    {

        if( FindObjectOfType<Level1Controller>().distanceFromFirstObject<2)
        {
            animationLonny.SetInteger("ToTalk", 0);
            count = 1;
        }
        else 
        {
            animationLonny.SetInteger("ToTalk", 1);
            count = 0;

        }

    }

    
    //method called to change the animation to talking
    public void LonnySpeak()
    {
        animationLonny.SetInteger("ToTalk", 0);
    }
    
}
