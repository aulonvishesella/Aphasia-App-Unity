using UnityEngine.Audio;
using UnityEngine;
using System;

//inspired from the youtube link /h/ttps://www.youtube.com/watch?v=6OT43pvUyfY
public class AudioManager : MonoBehaviour
{
    //the audio manager as an array of audios of type class : Audio
    public Audio[] audios;
    // Use this for initialization
    void Awake()
    {
        for (int i = 0; i < audios.Length; i++)
        {
            Audio a = audios[i];
            a.audioS = gameObject.AddComponent<AudioSource>();
            a.audioS.clip = a.audioC;
        }
    }

    //based on the name of the audio given, it will play the audio from the list of audios.
    public void AudioStart(string audioname)
    {

        //search through the list of audios stored.
        for (int i = 0; i < audios.Length; i++)
        {

            //if a audio name is equal to the name specified 
            if (audios[i].nameOfAudio == audioname)
            {
                //that audio 'a' is set to that audio and is played.
                Audio a = audios[i];
                a.audioS.Play();
            }
        }
    }

    //method to mute the volume when called.
    public void Mute(string nameOfAudio)
    {
        //search through the list of audios stored.
        for (int i = 0; i < audios.Length; i++)
        {
            //if a audio name is equal to the name specified 
            if (audios[i].nameOfAudio == nameOfAudio)
            {
                Audio s = audios[i];
                //stop playing the audio based off the name.
                s.audioS.Stop();
            }

        }

    }
}