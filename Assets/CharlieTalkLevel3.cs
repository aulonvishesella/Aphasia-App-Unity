using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;
public class CharlieTalkLevel3 : MonoBehaviour
{
    CharacterController controller;
    Animator animationCharlie;
    private int count = 0;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //retrieve the animations set for the player.
        animationCharlie = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<controllerforlevel3>().alreadyPlayedJumperAudio == true)
        {
            animationCharlie.SetInteger("CharlieTalk", 1);
            count = 1;
        }
        else
        {
            animationCharlie.SetInteger("CharlieTalk", 0);
            count = 0;
        }
    }
}
