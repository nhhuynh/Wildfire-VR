using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class InteractableObject_TurnOnTV : VRTK_InteractableObject
{
    public GameObject StartOnGrab;

    void Start()
    {
        // StartOnGrab is initialized to inactive by the Unity editor.
    }

    public override void Grabbed(VRTK_InteractGrab currentGrabbingObject = null)
    {
        base.Grabbed(currentGrabbingObject);
        StartOnGrab.SetActive(true);
    }
}
