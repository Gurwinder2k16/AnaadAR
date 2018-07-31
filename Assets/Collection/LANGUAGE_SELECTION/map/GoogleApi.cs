using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleApi : MonoBehaviour {

	public RawImage img;

	string url;

	public float lat;
	public float lon;

	LocationInfo li;

	public int zoom = 14;
	public int mapWidth =640;
	public int mapHeight = 640;

	public enum mapType {roadmap,satellite,hybrid,terrain}
	public mapType mapSelected;
	public int scale;


	IEnumerator Map()
	{
		//31.6211338,74.8772956
	   url = "https://maps.googleapis.com/maps/api/staticmap?center=" + "31.6211338" + "," + "74.8772956" +
			"&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale 
			+"&maptype=" + mapSelected +"&markers=color:blue%7Clabel:S%7C40.702147,-74.015794&markers=color:green%7Clabel:G%7C40.711614,-74.012318&markers=color:red%7Clabel:C%7C40.718217,-73.998284&key=AIzaSyD6AQzQcosydgrLEzbe9mf7Zd1wZnoF8Dw";
			Debug.Log(url);
		WWW www = new WWW (url);
		yield return www;
		img.texture = www.texture;
		img.SetNativeSize ();

	}
	// Use this for initialization
	void Start () {
		img = gameObject.GetComponent<RawImage> ();
		StartCoroutine (Map());
	}
	
	// Update is called once per frame
	void Update () {
		img = gameObject.GetComponent<RawImage> ();
		StartCoroutine (Map());
	}
}
