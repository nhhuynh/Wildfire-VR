using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Screen_Text : MonoBehaviour {

    public Text screenText;

    void Start()
    {
        UpdatePhone();
    }

    void UpdatePhone()
    {
        //once phone is picked up the ringing stops
    //    AudioSource phoneRing = transform.GetComponent<AudioSource>();
    //    phoneRing.loop = false;
    //    phoneRing.Stop();
        //new text is displayed
        screenText.text = "FIRE WARNING: Check local news";
        screenText.color = Color.red;
        // put highlight around remote next
    }
}