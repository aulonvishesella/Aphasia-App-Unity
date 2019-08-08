
// inspired from h/ttps://www.youtube.com/watch?v=hRRqxrWQJQg
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //this is in regards to the player. The player is the target where the camera needs to follow
    public Transform player;

    //the offset of the position
    public Vector3 posOffset;

    public Space posOffsetSpace= Space.Self;
    //this is setting the camera to look at the player automatically to true
    public bool isLookingAtPlayer = true;

    private void Update()
    {


        // compute position
        if (posOffsetSpace == Space.Self)
        {
            transform.position = player.TransformPoint(posOffset);
        }
        else
        {
            transform.position =player.position + posOffset;
        }

        // compute rotation
        if (isLookingAtPlayer)
        {
            transform.LookAt(player);
        }
        else
        {
            transform.rotation = player.rotation;
        }
    }

}
