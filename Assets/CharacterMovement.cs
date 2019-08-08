using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;

//some code whttps://www.youtube.com/watch?v=ReauId6jFFI&t=48s

public class CharacterMovement : MonoBehaviour
{

    float rotatePlayer = 0;


    Vector3 directionMoved = Vector3.zero;
    CharacterController controllerOfTheCharacter;
    Animator animationPlayer;

    void Start()
    {
        controllerOfTheCharacter = GetComponent<CharacterController>();
        //retrieve the animations set for the player.
        animationPlayer = GetComponent<Animator>();
    }

    void FixedUpdate()
    {



        //check that the player is standing on the ground. If it is, it can start moving.
        if (controllerOfTheCharacter.isGrounded)
        {
            //if the up key is pressed and if the position of the player is within the bounds set (e.g. x position <113)
            if (Input.GetKey(KeyCode.UpArrow) && FindObjectOfType<OutOfBoundary>().GetXPosition() < 113 && FindObjectOfType<OutOfBoundary>().GetXPosition() > -73 && FindObjectOfType<OutOfBoundary>().GetZPosition() > -48)
            {
                //sets the animation of the player to condition 1 which in the state machine is set to 'walking state'
                animationPlayer.SetInteger("animatorCondition", 1);
                //the direction moved will be forward by the z axis by 1.
                directionMoved = new Vector3(0, 0, 1);
                //the direction moved is multiplied by 5 which correlates to the speed travelling.
                directionMoved *= 5;
                directionMoved = transform.TransformDirection(directionMoved);
            }

            else if (Input.GetKey(KeyCode.UpArrow) && FindObjectOfType<OutOfBoundary>().GetXPosition() < -73)
            {
                //if we are not holding 'W', then state turn from WALKING to IDLE.
                animationPlayer.SetInteger("animatorCondition", 1);
                //do not move a direction.
                directionMoved = new Vector3(3, 0, 0);

            }

            //if the key 'w' is released, stop moving the character foward along the Z-Axis.
            else if (Input.GetKey(KeyCode.UpArrow) && FindObjectOfType<OutOfBoundary>().GetXPosition() > 113)
            {
                //if we are not holding 'W', then state turn from WALKING to IDLE.
                animationPlayer.SetInteger("animatorCondition", 1);
                //do not move a direction.
                directionMoved = new Vector3(-3, 0, 0);

            }
            else if (Input.GetKey(KeyCode.UpArrow) && FindObjectOfType<OutOfBoundary>().GetZPosition() < -48)
            {
                //if we are not holding 'W', then state turn from WALKING to IDLE.
                animationPlayer.SetInteger("animatorCondition", 1);
                //do not move a direction.
                directionMoved = new Vector3(0, 0, 5);
            }
            else
            {
                animationPlayer.SetInteger("animatorCondition", 0);
                //do not move a direction.
                directionMoved = new Vector3(0, 0, 0);
            }
        }

        //move player along y axis
        directionMoved.y -= 2 * Time.deltaTime;
        controllerOfTheCharacter.Move(directionMoved * Time.deltaTime);

        //call function to rotate the player
        permitRotation();

    }
    //function for the rotaiton of the player
    public void permitRotation()
    {
        //the rotation of player value is equal to the type of key pressed e.g. left multiplied by the speed multiplied by the time.
        rotatePlayer += Input.GetAxis("Horizontal") * 80 * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rotatePlayer, 0);

    }
}