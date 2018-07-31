using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine.UI;

	public class checkpoints_mssg:MonoBehaviour
	{
	public GameObject objects;
	Text chk_txt;
    void Start()
	{  
		chk_txt = GameObject.Find ("chk_Text").GetComponent<Text>();
		objects.SetActive (false);

	}
	public string get_text()
	{
		return chk_txt.text;
	}
	public void set_text(string text)
	{
		this.chk_txt.text = text.ToString();
	}
	public void show_pp()
	{   
		objects.SetActive (true);

	}
	public void hide_pp()
	{   
		objects.SetActive (false);

	}
	}


