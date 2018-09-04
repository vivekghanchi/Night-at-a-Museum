using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WayPoint : MonoBehaviour {

	public GameObject player, w1;
	public GameObject movie, audio;

	private int clickcount = 0;



	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveToWayPoint()
	{
		clickcount = clickcount + 1;
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", w1.transform.position,
				"time", 2,
				"easetype", "linear",
				"onComplete","PlayMedia",
				"oncompletetarget", gameObject
			));

		
	}

	public void PlayMedia(){
		if (clickcount <= 1) {
			AudioSource audioSource = audio.GetComponent<AudioSource> ();
			audioSource.Play ();
		}
	
	}





}
