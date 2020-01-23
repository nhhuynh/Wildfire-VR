using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTV : MonoBehaviour {

    public GameObject television;
    public AudioSource audio;

    void Start ()
    {
     //   PlayAudio = GameObject.FindGameObjectWithTag("PlayAudio");
        StartTV();
    }

    void StartTV()
    {
        //turns on TV
        audio = television.GetComponent<AudioSource>();
        var video = television.GetComponent<UnityEngine.Video.VideoPlayer>();
        audio.Play();
        video.Play();
        //waits a little so TV can play then makes phone ring
        StartCoroutine(StartKnoking());
    }

    private IEnumerator StartKnoking()
    {
        yield return new WaitForSeconds(10);
        //start door knocking
        GameObject door = GameObject.FindGameObjectWithTag("door");
        AudioSource doorKnock = door.GetComponent<AudioSource>();
        doorKnock.loop = true;
        doorKnock.Play();
    }
  /*  private IEnumerator PhoneRings()
    {
        yield return new WaitForSeconds(8);
        //get phone gameobject with tag
        GameObject phone = GameObject.FindGameObjectWithTag("cellPhone");
        //make phone ring
        AudioSource phoneRing = phone.GetComponent<AudioSource>();
        phoneRing.loop = true;
        phoneRing.Play();
    }
   */
}
