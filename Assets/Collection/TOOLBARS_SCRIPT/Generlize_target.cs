using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generlize_target : MonoBehaviour {

	public GameObject targets;
	public void set_active()
	{
		targets.SetActive (true);
	}
	public void hide_active()
	{
		targets.SetActive (false);
	}

	void Start () {
		hide_active ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
