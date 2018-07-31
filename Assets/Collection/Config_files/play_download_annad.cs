using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play_download_annad : MonoBehaviour {

	public VideoPlaybackBehaviour vb;Text tx;
	string temp;

    void Start() 
	{  
		vb.GetComponent<VideoPlaybackBehaviour> ();
		tx = GameObject.Find ("loc").GetComponent<Text> ();
	    temp = vb.m_path;

		if (!System.IO.File.Exists (Application.persistentDataPath + "/" + temp)) 
		{
			vb.m_path = "http://www.arptc.xyz/" +temp;

		} 
		else 
		{
			vb.m_path = Application.persistentDataPath + "/" + temp;

		}
	}
	void Update()
	{
		if(System.IO.File.Exists (Application.persistentDataPath + "/" + temp) && (vb.m_path!=Application.persistentDataPath + "/" + temp))
		{
			vb.m_path = Application.persistentDataPath + "/" + temp;
			vb.VideoPlayer.Play(false,0);


		}
	}


}
