using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LANGUAGE_BAR : MonoBehaviour {
	
    string target_name;
	bool abc = false;
	GameObject lang_canvas,extra_canvas_history;
	ArrayList_cous skelton;
	
	void Awake()
	{   
		lang_canvas = GameObject.Find ("lang_Canvas");
		extra_canvas_history = GameObject.Find ("External_history_panel");
		hide ();
	}
	//----------------------------prefb-action
	public void show()
	{
		lang_canvas.SetActive (true);
		GameObject.Find ("History_dec").GetComponent<Text> ().text = "Please Select Language!";
	
		
	}
	public void hide()
	{
		lang_canvas.SetActive (false);
		GameObject.Find ("History_dec").GetComponent<Text> ().text = "Please Select Language!";
	
	}
    public void lang_eng()
	{   
		set_text (skelton.eng);
		
	}
	public void lang_hindi()
	{
		set_text (skelton.hindi);
	}
	public void lang_punjabi()
	{	
		set_text(skelton.punj);
	
	}

	//------------------------------------A-I------------------
	void judge(string place)
	{
		ArrayList_implem temp= new ArrayList_implem ();
		if (place == "baba budha ber")
		{
			skelton =temp.history[temp.history.FindIndex(x => x.loc ==place)];
		}
		else if (place == "akal takhat")
		{
			skelton =temp.history[temp.history.FindIndex(x => x.loc == place)];
		}
		else if (place == "Harimandir sahib")
		{
			skelton =temp.history[temp.history.FindIndex (x => x.loc == place)];
		}
		else if (place == "Santokhsar Sahib")
		{
			skelton =temp.history[temp.history.FindIndex(x => x.loc == place)];
		}
		else if (place == "Dr. B.R Ambedkar")
		{
			skelton =temp.history[temp.history.FindIndex (x => x.loc == place)];
		}
		else if (place == "Maharja Ranjit Singh")
		{
			skelton =temp.history[temp.history.FindIndex(x => x.loc == place)];
		}
		else if (place == "Dukh Bhanjani Beer Sahib")
		{
			skelton =temp.history[temp.history.FindIndex(x => x.loc == place)];
		}


    }
	void set_text(string set)
	{
		GameObject.Find ("History_dec").GetComponent<Text> ().text = set; 
	}
	
	
   //----------------------------------Runtime-Internal--action-specific-history
	public void baba_budha_ji_history()
	{
		target_name = "baba budha ber";normalize (target_name,"Canvas_Main");
		
	}
	public void akal_takhat_history()
	{
		target_name = "akal takhat";normalize (target_name,"Canvas_Main");
	}
	public void harimandir_history()
	{
		target_name = "Harimandir sahib";normalize (target_name,"Canvas_Main");
	}
	public void Dukh_Bhanjani_Beer_Sahib_history()
	{
		target_name = "Dukh Bhanjani Beer Sahib";normalize (target_name,"Canvas_Main");
	}
	//----------------------------------Runtime-External-action-specific-history
	public void santokh_sar_history()
	{
		target_name = "Santokhsar Sahib";normalize (target_name,"Canvas_Main");

	}
	public void ambedkar_history()
	{
		target_name = "Dr. B.R Ambedkar";normalize (target_name,"Canvas_Main");
	}
	public void ranjit_singh_history()
	{
		target_name = "Maharja Ranjit Singh";normalize (target_name,"Canvas_Main");
	}



	void normalize(string target_name_his,string found_taget)
	{
		
		try
		{
		target_name = target_name_his;
		show ();
		}
		catch {
		}
		
		judge (target_name);
	}

	/*public IEnumerator download_history(string place,string lang) 
	{
		WWWForm form = new WWWForm();
		form.AddField("txt_place",place.ToString());
		form.AddField("txt_lang",lang.ToString());
		WWW www = new WWW("http://"+new Config().get_ip()+"/history_db.php", form);

		// Wait until the download is done
		yield return www;
		if(abc)
		{
		if(!string.IsNullOrEmpty(www.error)) {
			print( "Error downloading: " + www.error );
		} 
		else 
		{ 
			GameObject.Find ("History_dec_front").GetComponent<Text> ().text = www.text.Trim().ToString();
		
		}
		}
		else
		{
			if(!string.IsNullOrEmpty(www.error)) {
			print( "Error downloading: " + www.error );
		} 
		else 
		{ 
			GameObject.Find ("History_dec").GetComponent<Text> ().text = www.text.Trim().ToString();
		
		}
		}
	} 
	//--------------------------prefeb-----------------
	public void lang_eng()
	{
		//StartCoroutine (download_history(target_name,"english"));
	}
	public void lang_hindi()
	{
		//StartCoroutine (download_history(target_name,"hindi"));
	}
	public void lang_punjabi()
	{
		//StartCoroutine (download_history(target_name,"punjabi"));
	}
	//----------------------------------Runtime-action-specific-history
    public void baba_budha_ji_history()
	{
		target_name = "baba budha ber";
		normalize (target_name,"");
	}
	public void akal_takhat_history()
	{
		target_name = "akal takhat";normalize (target_name,"");
	}
	public void harimandir_history()
	{
		target_name = "Harimandir sahib";normalize (target_name,"A_B_C");
	}
	public void guru_ram_das_history()
	{
		target_name = "";normalize (target_name,"");
	}
	public void guru_arjan_dev_history()
	{
		target_name = "";normalize (target_name,"");
	}
	public void baba_deep_singh_ji_history()
	{
		target_name = "";normalize (target_name,"");
	}*/
}
