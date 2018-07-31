using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class video_manage : MonoBehaviour {

	public VideoPlayer vb;
	string temp="outer_view.mp4";

    void Start() 
	{  
		vb.GetComponent<VideoPlayer> ();
        if (!System.IO.File.Exists (Application.persistentDataPath + "/" + temp)) 
		{
			vb.url = "http://www.arptc.xyz/" + temp;
			vb.Play ();

		} 
		else 
		{
			vb.url = Application.persistentDataPath + "/" + temp;
			vb.Play ();


		}
	}
	void Update()
	{
		if(System.IO.File.Exists (Application.persistentDataPath + "/" + temp) && (vb.url!=Application.persistentDataPath + "/" + temp))
		{
			vb.url = Application.persistentDataPath + "/" + temp;
			vb.Play ();
		
		
		} 
	}


}
