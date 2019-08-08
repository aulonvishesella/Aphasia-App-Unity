using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class savetestscore : MonoBehaviour {
    public static int savetests = 0;
    public Text savescore;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        savescore.text = "Score:" + savetests;
    }
}
