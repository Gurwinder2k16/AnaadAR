using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tool_Bar : MonoBehaviour {

	public void exit()
	{
		System.GC.Collect();
		Application.Quit ();
	}
	public void logout()
	{
		System.GC.Collect();
		SceneManager.LoadScene ("Options");
	}
	public void board()
	{
		SceneManager.LoadScene ("Scoreboard");

	}
	public void back()
	{
		SceneManager.LoadScene ("Options");
	}
	public void view_map()
	{
		SceneManager.LoadScene ("map");	
	}

}
