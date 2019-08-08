using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundary : MonoBehaviour {
    public GameObject player;
    public float xpos;
    public float zpos;

    void Update()
    {
        xpos = GetXPosition();
        zpos = GetZPosition();
    }
	
	//returns the x position for the avatar
	public float GetXPosition()
    {
        return player.transform.position.x;
    }
    //returns the z position for the avatar
    public float GetZPosition()
    {
        return player.transform.position.z;
    }


}
