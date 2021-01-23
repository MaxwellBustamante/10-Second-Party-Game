using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnce : MonoBehaviour
{
    public AudioSource Source; 

    void Start()
    {
        Source = gameObject.GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        if(Source == null)
        {
            return;//this is to prevent errors/crashing that stem from the game trying to play audio that isnt there
        }

        if(Source.isPlaying == false)
        {
            Source.Play();//checks to see if its not playing, then plays it if so
        }
    }

    public void StopAudio()
    {
        if (Source == null)
        {
            return;
        }

        if (Source.isPlaying == true)
        {
            Source.Stop();
        }
    }
}
