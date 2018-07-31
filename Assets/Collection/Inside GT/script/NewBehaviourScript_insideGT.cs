using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript_insideGT : MonoBehaviour{

	int score=0;
	int max_score=600;
	public Text loc;
	static NewBehaviourScript_insideGT mins;
	Stack<string> stk=new Stack<string>();
	public GameObject check;
	string checked_level=null;
	string target;
	    public static NewBehaviourScript_insideGT instance 
	    {
		get {
			if (mins == null) {
				mins = new NewBehaviourScript_insideGT ();

			}
			return mins;

		}
		}
	void Awake()
	{
		check = GameObject.Find("Checkpoint_canvas");
	}
	public void set_score(int score)
	{
		this.score=score;
	}

	public int get_score()
	{
		return this.score;
	}
	void sub_process(int score,string target)
	{
		if (!stk.Contains (target)) {
			stk.Push (target);
			set_score (get_score () + 200);
			Debug.Log (target + " " + 200);
			if (done ()) {
				Debug.Log ("Check Point");
				StartCoroutine (sync_score ());

			} 
		}
	}
	public void process_do(int score,string target)
	{
		this.target = target;
		StartCoroutine (sync_download_completed_leve());

	}
	public IEnumerator sync_download_completed_leve() 
	{
		WWWForm form = new WWWForm();
		form.AddField("txt_email",new local_ctrl().get_email());
		form.AddField("txt_level",loc.text);
		WWW www = new WWW("http://"+new Config().get_ip()+"/sync_download_completed_leve.php", form);

		// Wait until the download is done
		yield return www;

		if(!string.IsNullOrEmpty(www.error)) {
			print( "Error downloading: " + www.error );
		} 
		else 
		{   string msssg = www.text.Trim().ToString();
			if (msssg=="completed")
			{  
				check.GetComponent<checkpoints_mssg> ().set_text ("You Already Completed this Level!!");
				check.GetComponent<checkpoints_mssg> ().show_pp ();
				checked_level = msssg;Debug.Log ("that point"+msssg);
			}
			else 
			{
				check.GetComponent<checkpoints_mssg> ().set_text ("");
				check.GetComponent<checkpoints_mssg> ().hide_pp ();
				checked_level = msssg;Debug.Log ("that point"+msssg);
				Debug.Log (checked_level);
				sub_process (score, target);
			}
		}
	}
	private IEnumerator<YieldInstruction> DoSomething()
	{
		check.GetComponent<checkpoints_mssg> ().set_text ("You Already Completed this Level!!");
		check.GetComponent<checkpoints_mssg> ().show_pp ();
		yield return new WaitForSeconds (2);
		check.GetComponent<checkpoints_mssg> ().set_text ("");
		check.GetComponent<checkpoints_mssg> ().hide_pp ();
		yield return null;

	}
	public bool done()
	{
		if (get_score () == max_score) 
		{
			return true;
		} 
		else
		{
			Debug.Log ("Remaing Score:-"+(max_score-get_score()).ToString());
			return false;
		}
	}
	public IEnumerator sync_score() 
	{
		WWWForm form = new WWWForm();
		form.AddField("txt_point",get_score().ToString());
		form.AddField("txt_email",new local_ctrl().get_email());
		form.AddField("txt_level",loc.text);
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

				check.GetComponent<checkpoints_mssg> ().set_text ("Check Point");
				check.GetComponent<checkpoints_mssg> ().show_pp ();
			} 
		}
	}

}