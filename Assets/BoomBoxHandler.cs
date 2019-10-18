using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomBoxHandler : MonoBehaviour
{
    int musicState;
    AudioSource audio1;
    AudioSource audio2;
    AudioSource audio3;
 
    // Start is called before the first frame update
    void Start()
    {
        var audioSources = GetComponents<AudioSource>();
        audio1 = audioSources[0];
        audio2 = audioSources[1];
        audio3 = audioSources[2];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool boombox_playing = false;
    public void toggle_boombox()
    {
        musicState++;

        if (musicState == 1)
        {
            audio1.Play();
        }
        else if (musicState == 2)
        {
            audio1.Stop();
            audio2.Play();
        }
        else if (musicState == 3)
        {
            audio2.Stop();
            audio3.Play();
        }
        else
        {
            musicState = 0;
            audio3.Stop();
        }
    }

}
