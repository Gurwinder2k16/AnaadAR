using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class arial_view_via_code : MonoBehaviour {

	VideoPlayer vp;
	GameObject[] loc=new GameObject[5];
	public int prev_index;
	void Awake () 
	{
		vp = GameObject.Find ("overview_holiday").GetComponent<VideoPlayer> ();
		loc [3] = GameObject.Find ("arial_harimandir");
		loc [0] = GameObject.Find ("arial_akal_takhat");
		loc [1] = GameObject.Find ("arial_dukh_bhanjan 2");
		loc [2] = GameObject.Find ("arial_dukh_bhanjan");
		loc [4] = GameObject.Find ("arial_baba_budha");
		show_loc_point_opti (-1);
		prev_index = -1;

	}
	

	void Update () 
	{
		//Debug.Log (vp.time);
		string time = vp.time.ToString ("N2");
		if(time=="00.00")
		{
			show_loc_point_opti (-1);
		}
		if(time=="15.00")
		{
			show_loc_point_opti (0);
		}
		else if(time=="20.00")
		{
			show_loc_point_opti (1);
		}
		else if(time=="22.00")
		{
			show_loc_point_opti (2);
		}
		else if(time=="28.00")
		{
			show_loc_point_opti (3);
		}
		else if(time=="34.00")
		{
			show_loc_point_opti (0);
		}
		else if(time=="67.00")
		{
			show_loc_point_opti (4);
		}
		else if(time=="72.00")
		{
			show_loc_point_opti (-1);
		}


	}

	public void show_loc_point_opti(int index)
	{  
		if (index != prev_index) {
			for (int i = 0; i < loc.Length; i++) {
				loc [i].SetActive (false);
			}
			if (index != -1) {
				loc [index].SetActive (true);
			}
			prev_index = index;
		}

	}
	public void pause()
	{
		vp.Pause();
	}
	public void resume()
	{
		//vp.prepareCompleted += PrepareCompleted;
		vp.Play ();

	}




}
