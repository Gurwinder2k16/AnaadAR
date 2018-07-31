using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class PlayerScoreList : MonoBehaviour {

	public GameObject playerScoreEntryPrefab;
	string jsonString;
	Boolean dowld=false;
	Players[] player;
	int lastChangeCounter;
    int Length;

	void Start()
	{
		StartCoroutine (Upload());
	}
	// Update is called once per frame
	void Update () {
		
		while(this.transform.childCount > 0) {
			Transform c = this.transform.GetChild(0);
			c.SetParent(null);  // Become Batman
			Destroy (c.gameObject);
		}
		for(int i=0;i<Length && dowld==true;i++)
		{
			GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
			go.transform.Find ("Username").GetComponent<Text> ().text = player [i].email;
			go.transform.Find ("Kills").GetComponent<Text> ().text = player [i].compl_level;
			go.transform.Find ("Deaths").GetComponent<Text> ().text = player [i].point;
            go.transform.SetParent(this.transform);

		}
	}
	IEnumerator Upload() 
	{
		WWW www = new WWW("http://"+new Config().get_ip()+"/leaderboard.php");
		yield return www;
		if(!string.IsNullOrEmpty(www.error)) 
		{
			print( "Error downloading: " + www.error);
		} 
		else 
		{   
			jsonString ="{\"Items\":"+ www.text+"}";
			Debug.Log(jsonString);
			player = JsonHelper.FromJson<Players>(jsonString);
			Length=player.Length;
			for (int i = 0; i < Length; i++) {
				GameObject go = (GameObject)Instantiate (playerScoreEntryPrefab);
				go.transform.SetParent (this.transform);
				go.transform.Find ("Username").GetComponent<Text> ().text = player [i].email;
				go.transform.Find ("Kills").GetComponent<Text> ().text = player [i].compl_level;
				go.transform.Find ("Deaths").GetComponent<Text> ().text = player [i].point;
				dowld = true;   go.transform.SetParent(this.transform);
			}
		}
	}
}
