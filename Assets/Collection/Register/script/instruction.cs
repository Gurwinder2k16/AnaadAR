using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class instruction : MonoBehaviour {
	public GameObject objects,object_taget,object_help;
	Text rules,heading;
	void Awake()
	{   rules = GameObject.Find("Rules").GetComponent<Text> ();
		heading = GameObject.Find("heading").GetComponent<Text> ();
		objects.SetActive (false);
        show_targets();
		hide_help();
	}
	public void show_pp()
	{ 
		heading.text = "Instruction's";
		StartCoroutine (Upload());
		objects.SetActive (true);
			
	}
	public void hide_pp()
	{   
		objects.SetActive (false);

	}
	public void show_targets()
	{ 
		object_taget.SetActive (true);
			
	}
	public void hide_targets()
	{   
		object_taget.SetActive (false);

	}
	public void show_help()
	{ 
		object_help.SetActive (true);

	}
	public void hide_help()
	{   
		object_help.SetActive (false);

	}
	public void show_about()
	{
	rules.text = "Anaad Application is an virtual guide to learn sikh history along with punjabi culture with help of visualization and technology.Objective of Application is to guide the user and help to enhance their knowledge with interesting facts such that scoring on each Marker shows on leaderboard.\n\nSpecial Thanks to S.G.P.C and PTC Network.\n\nDeveloped By:- Mandeep Singh & Gurwinder Singh.\n\nFor Technical Support\nEmail Id:- mocgurwinder@gmail.com\nsahil671@gmail.com";
		heading.text = "About";
		objects.SetActive (true);
	}
	IEnumerator Upload() 
	{
		WWW www = new WWW("http://"+new Config().get_ip()+"/instruction.php");
        yield return www;
		if(!string.IsNullOrEmpty(www.error)) 
		{
			print( "Error downloading: " + www.error);
		} 
		else 
		{   
			rules.text = www.text;
        }
	}
}
