using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSound : MonoBehaviour
{

    private AudioSource myClip;

    private void Start()
    {
        myClip = GetComponent<AudioSource>();
    }

    void SoundStop()
    {
        myClip.Stop();
    }
}
