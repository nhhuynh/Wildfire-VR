using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    public Light lightToRaise;    
    private float maxTime = 3; //30 seconds
    private float mEndTime = 0;
    private float mStartTime = 0;
 
    void Awake()
    {
        mStartTime = Time.time;
        mEndTime = mStartTime + maxTime;
    }
    void Update()
    {
        if (lightToRaise.shadowStrength >= .2)
            lightToRaise.shadowStrength -= Time.deltaTime * .075f;
    }
}
