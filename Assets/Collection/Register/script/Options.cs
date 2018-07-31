using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour {
	private Text err_msg;
	void Awake ()
	{
	err_msg = GameObject.Find ("Mssg").GetComponent<Text>();
    }
	void set_mssg(string mssg)
	{
		err_msg.text = mssg;
	}
	public void register()
	{
		SceneManager.LoadScene ("register");
	}
	public void login()
	{
		SceneManager.LoadScene ("Login");
	}
	public void exits()
	{
		Application.Quit ();
	}
	public void GUEST()
	{
		SceneManager.LoadScene ("Full_MARG");
	}
	public void PLAY()
	{
		if (first_login ()) {
			Debug.Log (new Config ().get_ip ());
			set_mssg ("Succesfully Logined!");
			SceneManager.LoadScene ("Full_MARG");
		} 
		else
		{
			set_mssg ("Please Login or Register First!");
		}
	}
	//------------First Login start
	Boolean first_login()
	{
		try
		{

			if((new local_ctrl().get_email() != null) && (new local_ctrl().get_player_name() != null)) 
			{
				return true;
			} 
		}
		catch
		{
			return false;
		}
		return false;
	}
	//------------First Login End
	public void gps()
	{
		SceneManager.LoadSceneAsync( "MENUS");
	}
}
