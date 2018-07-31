using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class sync: MonoBehaviour
	{
		
		string score,email,level;
    	
		public void set_score(int scores)
		{
		this.score = scores.ToString();
		}
		string get_score()
		{
		return score;
		}
		public void set_email()
		{
		this.email = new local_ctrl ().get_email ();
		}
		string get_email()
		{
			return email;
		}
	    public void set_level(string level)
		{
		this.level = level;
		}
		string get_level()
		{
		return level;
		}
	//---------------sync
	    public void sync_data()
		{
		    Debug.Log ((get_level () + " " + get_email() + " " + get_score()).ToString());
			StartCoroutine (sync_score());
		}
		public IEnumerator sync_score() 
		{
			WWWForm form = new WWWForm();
			form.AddField("txt_point",get_score().ToString());
			form.AddField("txt_email",get_email().ToString());
			form.AddField("txt_level",get_level().ToString());
		    WWW www = new WWW("http://"+new Config().get_ip()+"/score_sync.php", form);

			// Wait until the download is done
			yield return www;

			if(!string.IsNullOrEmpty(www.error)) {
				print( "Error downloading: " + www.error );
			} 
			else 
			{   string msssg = www.text.Trim().ToString();
			    Debug.Log (msssg);
				if (msssg=="Succesfully Registerd")
				{   
					
				} 
            }
		}
	//----------------dwnld

	}


