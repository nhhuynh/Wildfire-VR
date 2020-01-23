using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

/** In addition to providing the basic functionality of an InteractableObject, use the object's ability to recognize when it's being grabbed
 *  to enact the respective changes in the scene. These are done by storing the relevant scripts as game objects, and enabling/disabling those objects.
 *  
 *  Each game object must be defined in the unity inspector for this to be effective. The object names below match the names of the needed GameObjects for clarity. 
 * */

public class InteractableObject_StopSound : VRTK_InteractableObject {

    public AudioSource myClip;
    public GameObject SoundPlayer;
    public GameObject ChangeOnGrab;
    
    protected void Start()
    {
        myClip = GetComponent<AudioSource>();
       // ChangeOnGrab initialized as inactive from Unity Editor
    }

    public override void Grabbed(VRTK_InteractGrab currentGrabbingObject = null)
    {
        base.Grabbed(currentGrabbingObject);
        myClip.Stop();
        SoundPlayer.SetActive(false);
        ChangeOnGrab.SetActive(true);
    }
}
