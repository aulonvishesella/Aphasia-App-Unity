using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;
public class YunTalk : MonoBehaviour
{
    CharacterController controllerYun;
    Animator animationYun;
    private int count = 0;
    // Use this for initialization
    void Start()
    {
        controllerYun = GetComponent<CharacterController>();
        //retrieve the animations set for the avatar 'Charlie'.
        animationYun = GetComponent<Animator>();
    }


    void FixedUpdate()
    {

        if (FindObjectOfType<Level1Controller>().distanceFromFourthObject < 2)
        {
            animationYun.SetInteger("YunTalk", 1);
            //prevent the animation from looping
            count = 1;
        }
        else
        {
            animationYun.SetInteger("YunTalk", 0);
            count = 0;

        }
    }
}