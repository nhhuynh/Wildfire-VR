using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpread : MonoBehaviour
{
    public GameObject fireObject;
    private GameObject clone;
    private GameObject clone2;
    private List<GameObject> fireHolder = new List<GameObject>();
    private Vector3 newPos;
    private int whichAxisChanges;
    //private bool doesAxisChange;

    private void Start()
    {
        fireHolder.Add(fireObject);
        newPos = new Vector3(fireObject.transform.position.x, fireObject.transform.position.y, fireObject.transform.position.z);
        InvokeRepeating("MakeFlames", 0, 3.0f);
    }

    void MakeFlames()
    {
        print(fireHolder.Count);
       foreach (GameObject fire in fireHolder)
        {
            print("Fire Made");
            whichAxisChanges = Random.Range(1, 2);
            if(whichAxisChanges % 2 == 0)
            {
                newPos.z += Random.Range(1.0f, 1.25f);
                newPos.x += Random.Range(2.0f, 4.0f);
            } else
            {
                newPos.x += Random.Range(2.0f, 4.0f);
            }
            
            clone = Instantiate(fire, newPos, Quaternion.Euler(0, 0, Random.Range(-2.0f, 2.0f)));
            clone2 = Instantiate(clone, newPos, Quaternion.Euler(0, 0, Random.Range(-3.0f, 3.0f)));
            //fireHolder.Add(clone);
            //fireHolder.Add(clone2);

        }
    }

    //private void Update()
    //{
        //fireObject.transform.Translate(.01f, 0, .01f);
    //}
}
