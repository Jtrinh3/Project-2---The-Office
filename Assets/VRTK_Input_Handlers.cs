using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class VRTK_Input_Handlers : MonoBehaviour
{
    public bool boombox_status = false;
    AudioSource audioData;

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
        audioData = GameObject.Find("Boombox Button").GetComponent<AudioSource>();
        if(boombox_status == false) //music originally off
        {
            audioData.Play(); //turnt
            boombox_status = true;
        }
        else //music was on
        {
            audioData.Pause(); //turnt down (for what!?)
            boombox_status = false;
        }
    }

}
