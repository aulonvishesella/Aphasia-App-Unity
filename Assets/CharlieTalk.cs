using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;
public class CharlieTalk : MonoBehaviour {
    CharacterController controllerCharlie;
    Animator animationCharlie;
    public int count = 0;
    // Use this for initialization
    void Start () {
        controllerCharlie = GetComponent<CharacterController>();
        //retrieve the animations set for the avatar 'Charlie'.
        animationCharlie = GetComponent<Animator>();
    }


    void FixedUpdate()
    {

        if (FindObjectOfType<Level1Controller>().distanceFromThirdObject < 2)
        {
            animationCharlie.SetInteger("CharlieTalk", 1);
            //prevent the animation from looping
            count = 1;
        }
        else
        {
            animationCharlie.SetInteger("CharlieTalk", 0);
            count = 0;

        }
    }
}
