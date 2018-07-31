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



public class register : MonoBehaviour
{
	private InputField input,input1;
	private Text err_msg;
	string mail,password;

	//------------System Methods
    void Awake ()
	{
		input = GameObject.Find("name").GetComponent<InputField>();
		input1 = GameObject.Find("id").GetComponent<InputField>();
		err_msg = GameObject.Find ("Mssg").GetComponent<Text>();Debug.Log (new Config ().get_ip ());
	}


	//--------------Normalized Function
	string get_name()
	{
		return input.text;
	}
	string get_email()
	{
		return input1.text;
	}
	void set_mssg(string mssg)
	{
		err_msg.text = mssg;
	}



	//------------Register Button
	public void submit () 
	{
		if (valid (get_email (), get_name ())) 
		{
			set_mssg("*Note: Enter Correct Information for future updations.");
			StartCoroutine (Upload ());
		} 
		else
		{
			set_mssg("Invalid Info!..Please Check Details..");
		}
    }
	public void guest()
	{
		SceneManager.LoadSceneAsync( "Full_MARG", LoadSceneMode.Single);
	}
	public void board()
	{
		SceneManager.LoadSceneAsync( "Scoreboard", LoadSceneMode.Single);

	}
	//------------Login Button
	public void Login () 
	{
		if (valid (get_email (), get_name ())) 
		{
			set_mssg("*Note: Enter Correct Information for future updations.");
			StartCoroutine (Logined ());
		} 
		else
		{
			set_mssg("Invalid Info!..Please Check Details..");
		}
	}
	public void view_map()
	{
		SceneManager.LoadSceneAsync( "map", LoadSceneMode.Single);

	}



//---------Register on web
	IEnumerator Upload() 
	{
		WWWForm form = new WWWForm();
		form.AddField("txt_user",get_name());
		form.AddField("txt_email", get_email());
		form.AddField("txt_opt","1");
		WWW www = new WWW("http://"+new Config().get_ip()+"/user_login.php", form);

		// Wait until the download is done
		yield return www;

		if(!string.IsNullOrEmpty(www.error)) {
			print( "Error downloading: " + www.error );
		} 
		else 
		{  
			string msssg = www.text.Trim().ToString();
			Debug.Log (msssg);
			if (msssg=="Succesfully Registerd")
			{   
				new local_ctrl().Save ("sys.xml",get_name(),get_email());
				set_mssg (msssg);
				SceneManager.LoadScene ("Full_MARG");
			} 
			else if(msssg=="Email ID already Exist!!!") 
			{
				set_mssg (msssg);
			}


		}
	 }
//---------End Register on web

//---------Login on web
	IEnumerator Logined() 
	{
		WWWForm form = new WWWForm();
		form.AddField("txt_user",get_name());
		form.AddField("txt_email", get_email());
		form.AddField("txt_opt","2");
		WWW www = new WWW("http://"+new Config().get_ip()+"/user_login.php", form);

		// Wait until the download is done
		yield return www;

		if(!string.IsNullOrEmpty(www.error)) {
			print( "Error downloading: " + www.error );
		} 
		else 
		{   
			string msssg = www.text.Trim().ToString();
			Debug.Log (msssg);
			if (msssg=="Sucessfully Logined..")
			{   
				new local_ctrl().Save ("sys.xml",get_name(),get_email());
				set_mssg (msssg);
				SceneManager.LoadScene ("Full_MARG");

			} 
			else if(msssg=="Email ID not Exist!!!") 
			{
				set_mssg (msssg);
			}


		}
	}
	public void feedback()
	{
		SceneManager.LoadSceneAsync("feedback", LoadSceneMode.Single);
	}


	//--------------Validation zone start
	Boolean valid(string email,string name)
	{
		if ((email.Trim ().ToString () != "") && email.Contains ("@") && email.Contains (".") && (name.Trim ().ToString () != "")) 
		{
			if (email.Trim ().ToString () == name.Trim ().ToString ()) 
			{
				set_mssg ("User name and email id must be distinct!.."); 
				return false;
			}
			return true;
		}
		return false;
	}
}
