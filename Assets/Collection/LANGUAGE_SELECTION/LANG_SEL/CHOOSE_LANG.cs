using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHOOSE_LANG : MonoBehaviour {

	public static string language_selected=null;
	public GameObject language_chooser;
	public void Awake()
	{
		language_chooser = GameObject.Find ("Lang_chooser");
	}
	public void select_eng()
	{
		language_selected = "english";
		DontDestroyOnLoad (language_chooser); open ();
	}
	public void selected_punj()
	{
		language_selected = "punjabi";
		DontDestroyOnLoad (language_chooser); open ();
	}
	void open()
	{
		SceneManager.LoadSceneAsync("Options", LoadSceneMode.Single);
	}
}
