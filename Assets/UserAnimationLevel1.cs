using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;
public class UserAnimationLevel1 : MonoBehaviour {
    CharacterController controller;
    Animator animationPlayer;
    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
        //retrieve the animations set for the player.
        animationPlayer = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        animationPlayer.SetInteger("talking", 0);
    }

    public void speak()
    {
        animationPlayer.SetInteger("talking", 1);
    }
}
