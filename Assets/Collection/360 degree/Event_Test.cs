using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Event_Test : MonoBehaviour {

	public VideoPlayer vb;

	void Start() 
	{
		vb.GetComponent<VideoPlayer> ();

	}

	public void play()
	{
		if (vb.isPlaying) {
			vb.Pause ();
		} else {
			vb.Play ();
		}
	}

	 
}
