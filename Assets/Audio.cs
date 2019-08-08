using UnityEngine.Audio;
using UnityEngine;

//allows these attributes to be seen in the inspector
[System.Serializable]   
public class Audio{
    //an audio has a name, clip and a source. The source is hidden in unity and is shown when the game starts
    public string nameOfAudio;
    public AudioClip audioC;
    [HideInInspector]
    public AudioSource audioS; 
}
