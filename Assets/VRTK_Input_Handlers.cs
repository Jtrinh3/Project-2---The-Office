using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class VRTK_Input_Handlers : MonoBehaviour
{
    public bool boombox_status = false;
    AudioSource boomboxAudioData = GameObject.Find("Boombox Interactable").GetComponent<AudioSource>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void toggle_boombox()
    {

        if(boombox_status == false) //music originally off
        {
            boomboxAudioData.Play(); //turnt
            boombox_status = true;
        }
        else //music was on
        {
            boomboxAudioData.Pause(); //turnt down (for what!?)
            boombox_status = false;
        }
    }

}
