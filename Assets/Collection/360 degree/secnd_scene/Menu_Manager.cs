using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Manager : MonoBehaviour {

	public GameObject video,video1,scroll_order;
    public void Awake()
	{
		video.SetActive (false);
		scroll_order.SetActive (false);
		video1.SetActive (false);

	}

	public void back()
	{
		SceneManager.LoadScene ("Full_MARG");
	}
	public void menu()
	{
		System.GC.Collect();SceneManager.LoadScene ("Options");
	}
	public void exit()
	{
		System.GC.Collect();
		Application.Quit ();
	}
	public void guru_order()
	{
		video.SetActive (false);video1.SetActive (false);
		scroll_order.SetActive (true);
	
	}
	public void young()
	{
		video.SetActive (true);video1.SetActive (false);
		scroll_order.SetActive (false);
	
	    
	}
	public void overall_heli()
	{
		video1.SetActive (true);video.SetActive (false);
		scroll_order.SetActive (false);


	}
	public void internal_view()
	{
		System.GC.Collect();SceneManager.LoadScene ("vrdmo");


	}


}
