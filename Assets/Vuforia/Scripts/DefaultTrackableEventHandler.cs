/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
	/// <summary>
	/// A custom handler that implements the ITrackableEventHandler interface.
	/// </summary
	public class DefaultTrackableEventHandler : MonoBehaviour,
	ITrackableEventHandler
	{
		#region PRIVATE_MEMBER_VARIABLES

		private TrackableBehaviour mTrackableBehaviour;

		#endregion // PRIVATE_MEMBER_VARIABLES



		#region UNTIY_MONOBEHAVIOUR_METHODS
		GameObject Santokh_sar_History_T,Thara_sahib_head_T,DRAMBEDKAR_History_T,A_B_C,DuKhBhanjan_Bair_T,babaBudha_ji_T,Akal_Takhat_Sahib_T,RANJITSINGH_History_T,ROUND_CONFERENCE_T;
		public Text loc;
		string found=null;
		GameObject lang_canvas;
		void Awake()
		{
			init_cons ();
		}
		void init_cons()
		{
			A_B_C = GameObject.Find("A_B_C");
			DuKhBhanjan_Bair_T = GameObject.Find("DuKhBhanjan_Bair_T");
			babaBudha_ji_T = GameObject.Find("babaBudha_ji_T");
			Akal_Takhat_Sahib_T = GameObject.Find("Akal_Takhat_Sahib_T");
			RANJITSINGH_History_T = GameObject.Find("RANJITSINGH_Histrory");
			DRAMBEDKAR_History_T = GameObject.Find("DRAMBEDKAR_Histrory");
			Santokh_sar_History_T = GameObject.Find("Santokh_Sar_Sahib_Histrory");
			Thara_sahib_head_T= GameObject.Find("Thara_sahib_head_T");
			ROUND_CONFERENCE_T= GameObject.Find("ROUND_CONFERENCE_T");
			loc = GameObject.Find ("loc").GetComponent<Text>();
			lang_canvas = GameObject.Find ("lang_Canvas");
		}
		void Start()
		{ 
			mTrackableBehaviour = GetComponent<TrackableBehaviour>();
			if (mTrackableBehaviour)
			{
				mTrackableBehaviour.RegisterTrackableEventHandler(this);
			}

		}

		#endregion // UNTIY_MONOBEHAVIOUR_METHODS



		#region PUBLIC_METHODS

		/// <summary>
		/// Implementation of the ITrackableEventHandler function called when the
		/// tracking state changes.
		/// </summary>
		public void OnTrackableStateChanged(
			TrackableBehaviour.Status previousStatus,
			TrackableBehaviour.Status newStatus)
		{
			if (newStatus == TrackableBehaviour.Status.DETECTED ||
				newStatus == TrackableBehaviour.Status.TRACKED ||
				newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
			{
				OnTrackingFound();
			}
			else
			{
				OnTrackingLost();
			}
		}

		#endregion // PUBLIC_METHODS



		#region PRIVATE_METHODS

		//----------------------------found tracking----------------
		private void OnTrackingFound()
		{
			if (mTrackableBehaviour.name == "A" 
			|| mTrackableBehaviour.name == "B" 
			|| mTrackableBehaviour.name == "C") 
			{
				normale_track (mTrackableBehaviour.name.ToString (), A_B_C,"SachKhand Harimandir Sahib");
				
			} 
			else if (mTrackableBehaviour.name == "DuKhBhanjan_Bair") {
				normale_track (mTrackableBehaviour.name.ToString (), DuKhBhanjan_Bair_T,"SachKhand Harimandir Sahib");
				

			}
			else if (mTrackableBehaviour.name == "babaBudha_ji") {
				normale_track (mTrackableBehaviour.name.ToString (),babaBudha_ji_T,"SachKhand Harimandir Sahib");
				

			}
			else if (mTrackableBehaviour.name == "Thara_sahib") {
				normale_track (mTrackableBehaviour.name.ToString (),Thara_sahib_head_T,"SachKhand Harimandir Sahib");
				

			}
			else if (mTrackableBehaviour.name == "Akal_Takhat_Sahib") {
				normale_track (mTrackableBehaviour.name.ToString (),Akal_Takhat_Sahib_T,"SachKhand Harimandir Sahib");
				

			}
			else if (mTrackableBehaviour.name == "Santokh Sar Sahib")
			{
				if (found != mTrackableBehaviour.name) 
				{  //normale_track (mTrackableBehaviour.name.ToString (),Santokh_sar_History_T,"Santokh Sar Sahib");
					loc.text = ("Heritage Walk(Santokh Sar Sahib)").ToUpper().ToString();
					LANGUAGE_BAR obj = GameObject.Find ("ARCamera").GetComponent<LANGUAGE_BAR> ();
					obj.santokh_sar_history ();
					found = mTrackableBehaviour.name;
				}
			}
			else if (mTrackableBehaviour.name == "RANJITSINGH") 
			{
				if (found != mTrackableBehaviour.name) 
				{
					loc.text = ("Heritage Walk(Maharaja RANJIT SINGH)").ToUpper().ToString();
			   	    //GameObject newParent = GameObject.Find (mTrackableBehaviour.name.ToString ());RANJITSINGH_History_T.SetActive (true);
		    	   //RANJITSINGH_History_T.transform.parent = newParent.transform; 
				    LANGUAGE_BAR obj=GameObject.Find("ARCamera").GetComponent<LANGUAGE_BAR>();
			     	obj.ranjit_singh_history ();
				    found = mTrackableBehaviour.name;
				}

			}
		    else if (mTrackableBehaviour.name == "DRAMBEDKAR")
			{
				if (found != mTrackableBehaviour.name) 
				{
				    loc.text = ("Heritage Walk(DR.BR AMBEDKAR)").ToUpper().ToString();
					//GameObject newParent = GameObject.Find (mTrackableBehaviour.name.ToString ());DRAMBEDKAR_History_T.SetActive (true);
					//DRAMBEDKAR_History_T.transform.parent = newParent.transform; 
				    LANGUAGE_BAR obj=GameObject.Find("ARCamera").GetComponent<LANGUAGE_BAR>();
			    	obj.ambedkar_history ();
					found = mTrackableBehaviour.name;
				}

			}  
			else if (mTrackableBehaviour.name == "ROUND_CONFERENCE") 
			{
				normale_track (mTrackableBehaviour.name.ToString (),ROUND_CONFERENCE_T,"Heritage Walk(ROUND_CONFERENCE)");
			}  
			else 
			{
				common_render();
			}
			common_render();
			Debug.Log("Trackable " + mTrackableBehaviour.name + " found");
		}
         void common_render()
		 {    
			    Renderer[] rendererComponents = GetComponentsInChildren<Renderer> (true);
				Collider[] colliderComponents = GetComponentsInChildren<Collider> (true);

				// Enable rendering:
				foreach (Renderer component in rendererComponents) {
					component.enabled = true;
				}

				// Enable colliders:
				foreach (Collider component in colliderComponents) {
					component.enabled = true;
				}
		 }
		void normale_track(string found_taget,GameObject taget,string location)
		{
			loc.text = location.ToUpper().ToString();
			GameObject newParent = GameObject.Find(found_taget); taget.SetActive (true);
			taget.transform.position = new Vector3(0, 0,0);
			taget.transform.parent = newParent.transform; 
		}
	 //--------------------------------Lost tracking ---------------------------------
		private void OnTrackingLost()
		{
			    Renderer[] rendererComponents = GetComponentsInChildren<Renderer> (true);
				Collider[] colliderComponents = GetComponentsInChildren<Collider> (true);

				// Disable rendering:
				foreach (Renderer component in rendererComponents) {
					component.enabled = false;
				}

				// Disable colliders:
				foreach (Collider component in colliderComponents) {
					component.enabled = false;
				}
				hide_target ();
		     	reset_camera ();
				Debug.Log ("Trackable " + mTrackableBehaviour.TrackableName + " lost");
				
		}
		void hide_target()
		{
			A_B_C.SetActive (false);
			Santokh_sar_History_T.SetActive (false);
			DuKhBhanjan_Bair_T.SetActive (false);
			babaBudha_ji_T.SetActive (false);
			Akal_Takhat_Sahib_T.SetActive (false);
			DRAMBEDKAR_History_T.SetActive (false);
			RANJITSINGH_History_T.SetActive (false);
			Thara_sahib_head_T.SetActive (false);
			ROUND_CONFERENCE_T.SetActive (false);
			
			
		}
		
		void reset_camera()
		{
			GameObject.Find ("ARCamera").GetComponent<Transform> ().position = new Vector3 (0, 0, 0);
			GameObject.Find ("ARCamera").GetComponent<Transform> ().rotation = new Quaternion (0, 0, 0, 0);
		}
		#endregion // PRIVATE_METHODS
	}
}
