using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour {

    public GameObject Player;
    public float distanceFromFirstObject;
    public float distanceFromSecondObject;
    public float distanceFromThirdObject;
    public float distanceFromFourthObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        distanceFromFirstObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").transform.position);
        distanceFromSecondObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").transform.position);
        distanceFromThirdObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("JumperObjective").transform.position);
        distanceFromFourthObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").transform.position);

    }

    public float returnDistance(string name) 
    {
        if (name == "distanceFromFirstObject")
        {
            return distanceFromFirstObject;
        }
        else if (name == "distanceFromSecondObject")    
        {
            return distanceFromSecondObject;
        }
        else if (name == "distanceFromThirdObject")
        {
            return distanceFromThirdObject;
        }
        else if (name == "distanceFromFourthObject")
        {
            return distanceFromFourthObject;
        }
        else
        {
            return 0;
        }
        
    }
}
