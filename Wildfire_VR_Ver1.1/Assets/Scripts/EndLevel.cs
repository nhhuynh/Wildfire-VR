using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class EndLevel : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        if (other.gameObject.layer == 2)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
