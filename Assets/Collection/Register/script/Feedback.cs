using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine.SceneManagement;

public class Feedback : MonoBehaviour {
	//-----------Server Config
	private InputField input;
	void Awake ()
	{
		input = GameObject.Find("feedback_msssg").GetComponent<InputField>();
	
	}
	string get_mssg()
	{
		return input.text;
	}
	public void submit()
	{
		StartCoroutine (Upload());	
	}
		IEnumerator Upload() 
		{
			WWWForm form = new WWWForm();
			form.AddField("txt_mssg",get_mssg());
		    form.AddField("txt_email",new local_ctrl().get_email());
			
	    	WWW www = new WWW("http://"+new Config().get_ip()+"/feedback.php", form);

			// Wait until the download is done
			yield return www;

			if(!string.IsNullOrEmpty(www.error)) {
				print( "Error downloading: " + www.error );
			} 
			else 
			{   
			    string msssg = www.text.Trim().ToString();
				Debug.Log (msssg);
			    if (msssg=="Send Succesfully")
				{   
				Debug.Log (msssg);
				SceneManager.LoadScene ("Options");
				} 
			}
		}



}
