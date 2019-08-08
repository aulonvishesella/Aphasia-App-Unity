using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;

public class BobTalkLevel2 : MonoBehaviour {
    CharacterController controller;
    Animator animationBob;
    private int count = 0;
    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
        //retrieve the animations set for the player.
        animationBob = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (FindObjectOfType<levelcontroller2>().alreadyPlayedSunAudio == true)
        {
            animationBob.SetInteger("IsSpeaking", 1);
            count = 1;
        }
        else
        {
            animationBob.SetInteger("IsSpeaking", 0);
            count = 0;
        }
    }
}
