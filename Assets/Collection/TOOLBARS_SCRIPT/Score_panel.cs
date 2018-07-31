using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


public class Score_panel : MonoBehaviour {
	string loc="";

	public string get_loc()
	{
		return loc;
	}
	public void set_loc(string loc)
	{
		GameObject.Find ("loc").GetComponent<Text> ().text =loc.ToUpper();
		this.loc=loc;
	}
	void Awake()
	{
		String player_name=new local_ctrl().get_player_name().ToUpper ();
		if (player_name != "") {
			GameObject.Find ("player").GetComponent<Text> ().text = player_name;
			GameObject.Find ("points_jwb").GetComponent<Text> ().text = "0";
		} else {
			GameObject.Find ("player").GetComponent<Text> ().text ="GUEST";
			GameObject.Find ("points_jwb").GetComponent<Text> ().text = "GUEST";
		}

		GameObject.Find ("loc").GetComponent<Text> ().text = loc.ToUpper();
	}
}
