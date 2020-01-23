using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour {

    public Transform startMarker;
    public Transform[] endMarker;
    public AudioSource siren;
    public float speed = 0.2F;
    private float startTime;
    private float journeyLength;
    private int markerNum = 0;
    private bool moveTruck = false;

    public void MakeMove()
    {
        siren = GetComponent<AudioSource>();
        siren.Play();
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        yield return new WaitForSeconds(10);
        getDist(markerNum);
        moveTruck = true;
    }

    void getDist(int i)
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker[i].position);
    }

    void Update()
    {
        if (moveTruck)
        {
            //set up distance truck needs to travel
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            //if truck has hit last point delete it
            if (markerNum == endMarker.Length)
            {
                Destroy(transform.gameObject);
            }
            //if truck has hit a node move to the next one
            else if (fracJourney > .1)
            {
                markerNum++;
                getDist(markerNum);
                //make truck look at node
                transform.LookAt(endMarker[markerNum]);
            }
            //move truck
            transform.position = Vector3.Lerp(startMarker.position, endMarker[markerNum].position, fracJourney);
        }
    }

}
