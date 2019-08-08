using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;
public class BobTalk : MonoBehaviour {
    CharacterController controllerBob;
    Animator animationBob;
    public int count = 0;
    // Use this for initialization
    void Start () {
        controllerBob = GetComponent<CharacterController>();
        //retrieve the animations set for the avatar 'Bob'.
        animationBob = GetComponent<Animator>();
    }

    void FixedUpdate()
    {

        if (FindObjectOfType<Level1Controller>().distanceFromSecondObject < 2)
        {
            animationBob.SetInteger("IsSpeaking", 1);
            //prevent the animation from looping
            count = 1;
        }
        else
        {
            animationBob.SetInteger("IsSpeaking", 0);
            count = 0;

        }
    }
}
