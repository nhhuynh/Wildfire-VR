using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSphere : MonoBehaviour {

    void Update()
    {
        // Grow the fire in the X & Y directions
        transform.localScale += new Vector3(Time.deltaTime, 0f, Time.deltaTime);
    }
}
