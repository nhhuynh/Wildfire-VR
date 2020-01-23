using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class InteractableObject_StopKnocking : VRTK_InteractableObject {

    public Animator animator;
    public TruckMovement truckScript;
    public AudioClip aud;
    public GameObject fire;
	public GameObject SoundManager;
	bool hasPlayed = false;

    void Start ()
    {
	}

    public override void StartTouching(VRTK_InteractTouch currentTouchingObject = null)
    {
        base.StartTouching(currentTouchingObject);
        GameObject door = GameObject.FindGameObjectWithTag("door");
        AudioSource doorKnock = door.GetComponent<AudioSource>();
        if (doorKnock.clip != aud && hasPlayed == false) // make sure this doesn't trigger more than once. 
        {
            doorKnock.Stop();
			SoundManager.GetComponent<SoundManager> ().playPoliceScript ();
            fire.SetActive(true);
        }
            
        GameObject police = GameObject.FindGameObjectWithTag("police");
        animator = police.GetComponent<Animator>();
        animator.SetBool("Open door", true);    // set policeman to begin pointing, and the rest of his animation.

        GameObject firetruck = GameObject.FindGameObjectWithTag("firetruck");
        truckScript = firetruck.GetComponent<TruckMovement>();
        truckScript.MakeMove();    // firetruck drives away
    }
}
