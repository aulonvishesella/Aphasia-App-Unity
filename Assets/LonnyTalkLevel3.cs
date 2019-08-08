using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;

public class LonnyTalkLevel3 : MonoBehaviour
{
    CharacterController controller;
    Animator animationLonny;
    private int count = 0;
    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //retrieve the animations set for the player.
        animationLonny = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (FindObjectOfType<controllerforlevel3>().alreadyPlayedCoffeeAudio == true)
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
}