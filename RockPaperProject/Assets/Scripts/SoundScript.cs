using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public float audiocounter;
    public float audioCounter2;
    public bool playing;
    public bool playSong;

    public AudioSource soundTrack;

    public AudioSource soundPlayer;

    // Update is called once per frame
    void Update()
    {
        audioCounter2 += Time.deltaTime;
        if(audioCounter2 >= 1.25f)
        {
            playSong = true;
        }

        if(playSong == true)
        {
            soundTrack.volume += Time.deltaTime * 2;
        }
        if(playing == true)
        {
            audiocounter += Time.deltaTime;
            if(audiocounter >= 2.5f)
            {
                playing = false;
            }
        }
    }

    public void PlaySound()
    {
        soundPlayer.Play();
        playing = true;
    }
}
