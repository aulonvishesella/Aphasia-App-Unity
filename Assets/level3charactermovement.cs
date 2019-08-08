using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;



// used some code from h/ttps://www.youtube.com/watch?v=ReauId6jFFI&t=48s
public class level3charactermovement : MonoBehaviour
{
    float rotatePlayer = 0;
    Vector3 directionMoved = Vector3.zero;
    CharacterController controller;
    Animator animationPlayer;




    void Start()
    {
        controller = GetComponent<CharacterController>();
        //retrieve the animations set for the player.
        animationPlayer = GetComponent<Animator>();

    }



    void FixedUpdate()
    {

        //check that the player is standing on the ground. If it is, it can start moving.
        if (controller.isGrounded)
        {


            //if the up key is pressed, move the character foward along the Z-Axis. Z position must be >-93

            if (Input.GetKey(KeyCode.UpArrow) && FindObjectOfType<OutOfBoundary>().GetZPosition() >-93)
            {
                //sets the animation of the player to condition 1 which in the state machine is set to 'walking state'
                animationPlayer.SetInteger("animatorCondition", 1);
                //the direction moved will be forward by the z axis by 1.
                directionMoved = new Vector3(0, 0, 1);
                //the direction moved is multiplied by 5 which correlates to the speed travelling.
                directionMoved *= 5;
                directionMoved = transform.TransformDirection(directionMoved);
            }

            //if z position less than -93, out of bounds so walk the opposite way
            else if(Input.GetKey(KeyCode.UpArrow) && FindObjectOfType<OutOfBoundary>().GetZPosition() < -93)
            {  //sets the animation of the player to condition 1 which in the state machine is set to 'walking state'
                animationPlayer.SetInteger("animatorCondition", 1);
                //the direction moved will be forward by the z axis by 1.
                directionMoved = new Vector3(0, 0, 4);
       
            }
            else
            {
                animationPlayer.SetInteger("animatorCondition", 0);
                //do not move a direction.
                directionMoved = new Vector3(0, 0, 0);
            }
        }

        //call function to rotate
        permitRotation();
        //move along the y axis
        directionMoved.y -= 2 * Time.deltaTime;
        controller.Move(directionMoved * Time.deltaTime);


    }

    public void permitRotation()
    {
        //allows to the use characters 'A' and 'D' to rotate the character left or right respectiviley.
        rotatePlayer += Input.GetAxis("Horizontal") * 80 * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rotatePlayer, 0);
    }
}
