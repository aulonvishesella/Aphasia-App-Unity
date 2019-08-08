using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.Audio;

public class CalculateDistance : MonoBehaviour {
    
    public GameObject Player;
    public float distanceFromFirstObject;
    public float distanceFromSecondObjet;
    public float distanceFromThirdObject;
    public float distanceFromFourthObject;
    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void FixedUpdate () {
      
        distanceFromFirstObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("CoffeeObjective").transform.position);
        distanceFromSecondObjet = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("SunObjective").transform.position);
        distanceFromThirdObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("SwimmingObjective").transform.position);
        distanceFromFourthObject = Vector3.Distance(Player.transform.position, FindObjectOfType<objectiveController>().RetrieveObjective("MilkObjective").transform.position);
     
    }

    public float returnDistance1()
    {
        return distanceFromFirstObject;
    }
    public float returnDistance2()
    {
        return distanceFromSecondObjet;
    }
    public float returnDistance3()
    {
        return distanceFromThirdObject;
    }

    public float returnDistance4()
    {
        return distanceFromFourthObject;
    }

    

  
}
