using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common_pref_normal : MonoBehaviour {
public GameObject prefab;
    void Awake()
	{
		//Screen.SetResolution (1920, 1080, true);
		Vector3 pos = new Vector3 (0, 0, 0);
		Instantiate (prefab, pos, Quaternion.identity);
	}
	void Start()
	{
		//Screen.SetResolution (1920, 1080, true);
	}
}
