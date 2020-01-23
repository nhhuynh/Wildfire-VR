using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnocking : MonoBehaviour {

    private AudioSource myClip;

    private void Start()
    {
        myClip = GetComponent<AudioSource>();
    }

    void SoundStop()
    {
        myClip.Stop();
        //door needs to swing open
        OpenDoor();
    }

    void OpenDoor()
    {

    }
}
