using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    private Vector3 startingPosition = new Vector3(68.232f, 1.53f, 161.574f);
    private Quaternion rot = new Quaternion(0, 0, 0, 0);

    void OnTriggerEnter(Collider other)
    {
        //print("HelloW" + other.gameObject);
        //if (other.gameObject.tag == "Player")
        if (other.gameObject.layer == 2)
        {
            print("insideIf");
            other.gameObject.transform.SetPositionAndRotation(startingPosition, rot);   // set player to starting position
        }
    }
}
