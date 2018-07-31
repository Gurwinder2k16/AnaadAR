using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class download_asset_anaad : MonoBehaviour {
	Stack<string> name_asset;
	string videoFile;

	void Start () 
	{
		name_asset=new Stack<string>();
	
        name_asset.Push ("first.mp4");
		name_asset.Push ("second.mp4");
		name_asset.Push ("third.mp4");
		name_asset.Push ("fourth.mp4");
		name_asset.Push ("fifth.mp4");
		name_asset.Push ("sixth.mp4");
		name_asset.Push ("bhangra.mp4");
		name_asset.Push ("gidha.mp4");
		name_asset.Push ("bibi_rajni.mp4");
		name_asset.Push ("bibi_rajni2.mp4");
		name_asset.Push ("outer_view.mp4");
	    StartCoroutine (DownloadAndPlayVideo ());
	}
	
   
	IEnumerator DownloadAndPlayVideo () {
		

		while(name_asset.Count!=0)
		{
			Debug.Log ("start Download");		
            if (Application.platform == RuntimePlatform.WindowsPlayer)
			{
				videoFile = Application.dataPath + "/StreamingAssets/" + name_asset.Peek ();
            }
			else if(Application.platform == RuntimePlatform.Android)
			{
					videoFile = Application.persistentDataPath+"/" + name_asset.Peek ();
				   
			}
			else if(Application.platform == RuntimePlatform.IPhonePlayer)
			{
				videoFile =  Application.persistentDataPath+"/"+ name_asset.Peek ();

			}
			if (System.IO.File.Exists (videoFile))
			{
				name_asset.Pop ();

			}
			else 
			{
				WWW www = new WWW ("http://www.arptc.xyz/" + name_asset.Peek ());
				Debug.Log ("http://www.arptc.xyz/" + name_asset.Peek ());
				yield return www;
				if (www != null && www.isDone && www.error == null)
				{
					FileStream stream = new FileStream (videoFile, FileMode.Create);
					stream.Write (www.bytes, 0, www.bytes.Length);
					stream.Close ();
					name_asset.Pop ();
					Debug.Log ("Download done");
                }
			}
		}
	}
}
