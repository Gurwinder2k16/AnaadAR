using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;
 
public class score_jwb : MonoBehaviour, ITrackableEventHandler {
     
    private TrackableBehaviour mTrackableBehaviour;
    private bool mShowGUIButton = false;
    private Rect mButtonRect = new Rect(50,50,120,60);
    void Start ()
	{
		 mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
     
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||  newStatus == TrackableBehaviour.Status.TRACKED)
        {
            mShowGUIButton = true;
        }
        else
        {
            mShowGUIButton = false;
        }
    }
     
    void OnGUI()
	{
		if (mShowGUIButton) {
			if (GameObject.Find ("player").GetComponent<Text> ().text != "GUEST") {
				GameObject.Find ("JallianWalaBagh").GetComponent<NewBehaviourScript_jwb> ().process_do (10, this.gameObject.name);
				GameObject.Find ("points_jwb").GetComponent<Text> ().text = GameObject.Find ("JallianWalaBagh").GetComponent<NewBehaviourScript_jwb> ().get_score ().ToString ();      
			}
		}
    }
}