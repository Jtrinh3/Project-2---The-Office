using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class VRTK_Input_Handlers : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool boombox_playing = false;
    public void toggle_boombox()
    {
        AudioSource boombox = GetComponent<AudioSource>();
        if(boombox_playing == false) //music originally off
        {
            boombox.Play();
            boombox_playing = true;
        }
        else //music was on
        {
            boombox.Pause(); //turnt down (for what!?)
            boombox_playing = false;
        }
    }

}
