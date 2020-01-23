using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioSource policeScript;
	bool hasPlayed = false;

	public void playPoliceScript(){
		if(hasPlayed == false){
		policeScript.Play();
		}
		hasPlayed = true;
	}
}

