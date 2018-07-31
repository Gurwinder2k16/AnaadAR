/*============================================================================== 
 * Copyright (c) 2012-2015 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
/// </summary>
public class TrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    #region PRIVATE_MEMBERS
    private TrackableBehaviour mTrackableBehaviour;
    private bool mHasBeenFound = false;
    private bool mLostTracking;
    private float mSecondsSinceLost;
    #endregion // PRIVATE_MEMBERS


    #region MONOBEHAVIOUR_METHODS

	Text loc;VideoPlaybackBehaviour video;
	GameObject Wall_object,Well_object,Internal,Door_object,front_obj,Sara_obj,SANTOKHSAR_PATTERN_obj,NEAR_POLICE_WALL_obj,PAT2_dawar_obj,AFTER_MART_obj,NEAR_JODA_GHAR_Head_obj,ENTRY_GT_JALLI_obj,DAK_obj,PAT1_obj,BHANGRA_obj,GIDHA_obj,PHASE_OBJ;
	void Awake()
	{
		loc = GameObject.Find ("loc").GetComponent<Text>();
		init_cons ();
	}
	void init_cons()
	{
		Wall_object= GameObject.Find("Wall_object");
		Well_object = GameObject.Find("Well_object");
		Internal = GameObject.Find("Internal");
		Door_object= GameObject.Find("Door_object");
		front_obj = GameObject.Find("front_obj");
		Sara_obj = GameObject.Find("Sara_obj");
		SANTOKHSAR_PATTERN_obj= GameObject.Find("SANTOKHSAR_PATTERN_obj");
		NEAR_POLICE_WALL_obj = GameObject.Find("NEAR_POLICE_WALL_obj");
		PAT2_dawar_obj = GameObject.Find("PAT2_dawar_obj");
		AFTER_MART_obj= GameObject.Find("AFTER_MART_obj");
		NEAR_JODA_GHAR_Head_obj= GameObject.Find("NEAR_JODA_GHAR_Head_obj");
		ENTRY_GT_JALLI_obj= GameObject.Find("ENTRY_GT_JALLI_obj");
		DAK_obj= GameObject.Find("DAK_obj");
		PAT1_obj = GameObject.Find("PAT1_obj");
		BHANGRA_obj = GameObject.Find("BHANGRA_obj");
		GIDHA_obj= GameObject.Find("GIDHA_obj");
		PHASE_OBJ= GameObject.Find("PHASE_OBJ");
	
		
	}
	void hide_target()
	{   Wall_object.SetActive (false);
		Well_object.SetActive (false);
		Internal.SetActive (false);
		Door_object.SetActive (false);
		front_obj.SetActive (false);
		Sara_obj.SetActive (false);
		SANTOKHSAR_PATTERN_obj.SetActive (false);
		NEAR_POLICE_WALL_obj.SetActive (false);
		PAT2_dawar_obj.SetActive (false);
		AFTER_MART_obj.SetActive (false);
		NEAR_JODA_GHAR_Head_obj.SetActive (false);
		ENTRY_GT_JALLI_obj.SetActive (false);
		DAK_obj.SetActive (false);
		PAT1_obj.SetActive (false);
		BHANGRA_obj.SetActive (false);
		GIDHA_obj.SetActive (false);
		PHASE_OBJ.SetActive (false);
	}

	void reset_camera()
	{
		GameObject.Find ("ARCamera").GetComponent<Transform> ().position = new Vector3 (0, 0, 0);
		GameObject.Find ("ARCamera").GetComponent<Transform> ().rotation = new Quaternion (0, 0, 0, 0);
	}

	//--------------------------------------------------------
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

        OnTrackingLost();
    }

    void Update()
    {
        // Pause the video if tracking is lost for more than two seconds
        if (mHasBeenFound && mLostTracking)
        {
            if (mSecondsSinceLost > 2.0f)
            {
                VideoPlaybackBehaviour video = GetComponentInChildren<VideoPlaybackBehaviour>();
                if (video != null &&
                    video.CurrentState == VideoPlayerHelper.MediaState.PLAYING)
                {
                    video.VideoPlayer.Pause();
                }

                mLostTracking = false;
            }

            mSecondsSinceLost += Time.deltaTime;
        }
    }

    #endregion //MONOBEHAVIOUR_METHODS


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
    #endregion //PUBLIC_METHODS


    #region PRIVATE_METHODS
    private void OnTrackingFound()
    {
			if (mTrackableBehaviour.name == "Front_view")
			{
			normale_track (mTrackableBehaviour.name.ToString (),front_obj,"JallianWalaBagh");
			}
			if(mTrackableBehaviour.name == "Wall")
			{
			normale_track (mTrackableBehaviour.name.ToString (),Wall_object,"JallianWalaBagh");
			}
			if(mTrackableBehaviour.name == "Well")
			{
				normale_track (mTrackableBehaviour.name.ToString (),Well_object,"JallianWalaBagh");
			}
			if(mTrackableBehaviour.name == "Internal Room")
			{
			normale_track (mTrackableBehaviour.name.ToString (),Internal,"JallianWalaBagh");
			}
			if(mTrackableBehaviour.name == "Door")
			{
			normale_track (mTrackableBehaviour.name.ToString (),Door_object,"JallianWalaBagh");
				
			}
			else if (mTrackableBehaviour.name == "Saragarhi")
			{
				normale_track (mTrackableBehaviour.name.ToString (),Sara_obj,"Saragarhi");
			}
			else if ((mTrackableBehaviour.name == "SANTOKHSAR_PATTERN"))
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),SANTOKHSAR_PATTERN_obj,"Heritage Walk(Near Santokhsar Sahib)");
			}
			else if (mTrackableBehaviour.name == "POLICE_WALL")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),NEAR_POLICE_WALL_obj,"Heritage Walk(Baba Deep singh ji Gate)");
			}
		    else if (mTrackableBehaviour.name == "DOORS_DIWAR")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),PAT2_dawar_obj,"Heritage Walk(Gate JallianWala Bagh)");
			}
			else if (mTrackableBehaviour.name == "AFTER_MART")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),AFTER_MART_obj,"Heritage Walk(Golden Temple Market)");
			}
			else if (mTrackableBehaviour.name == "NEAR_JODA_GHAR")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),NEAR_JODA_GHAR_Head_obj,"Heritage Walk(Near Jodha Ghar)");
			}
			else if (mTrackableBehaviour.name == "JALLI1")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),ENTRY_GT_JALLI_obj,"Heritage Walk(Entry Golden Temple)");
			}//-----------------bibi rajni---------------
			else if (mTrackableBehaviour.name == "DAK_HOUSE")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),DAK_obj,"Heritage Walk(Bank House)");
			}
			else if (mTrackableBehaviour.name == "MAHAl+DOORS_1")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),PAT1_obj,"Heritage Walk(Front Bank House)");
			}//-------------------cultural----------
			else if (mTrackableBehaviour.name == "BHANGRA")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),BHANGRA_obj,"Heritage Walk(Bhangra Statue)");
			}
			else if (mTrackableBehaviour.name == "GIDHA")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),GIDHA_obj,"Heritage Walk(Gidha Statue)");
			}
			else if (mTrackableBehaviour.name == "PHASE")
			{ 	
			normale_track (mTrackableBehaviour.name.ToString (),PHASE_OBJ,"Heritage Walk(Jallianwala Bagh Statue)");
			}
            Debug.Log("Trackable " + mTrackableBehaviour.name + " found");

       
    }
	void normale_track(string found_taget,GameObject taget,string location)
	{
		loc.text = location.ToUpper().ToString();
		GameObject newParent = GameObject.Find(found_taget); taget.SetActive (true);
		taget.transform.position = new Vector3(0, 0,0);
		taget.transform.parent = newParent.transform;
		common_render ();
	}
	void common_render()
	{
		Renderer[] rendererComponents = GetComponentsInChildren<Renderer>();
		Collider[] colliderComponents = GetComponentsInChildren<Collider>();

		// Enable rendering:
		foreach (Renderer component in rendererComponents)
		{
			component.enabled = true;
		}

		// Enable colliders:
		foreach (Collider component in colliderComponents)
		{
			component.enabled = true;
		}

		Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");

		// Optionally play the video automatically when the target is found
		play_videos_found();

	}
	void play_videos_found()
	{
		video = GetComponentInChildren<VideoPlaybackBehaviour>();
		if (video != null && video.AutoPlay)
		{
			if (video.VideoPlayer.IsPlayableOnTexture())
			{
				VideoPlayerHelper.MediaState state = video.VideoPlayer.GetStatus();
				if (state == VideoPlayerHelper.MediaState.PAUSED ||
					state == VideoPlayerHelper.MediaState.READY ||
					state == VideoPlayerHelper.MediaState.STOPPED)
				{
					// Pause other videos before playing this one
					PauseOtherVideos(video);

					// Play this video on texture where it left off
					video.VideoPlayer.Play(false, video.VideoPlayer.GetCurrentPosition());
				}
				else if (state == VideoPlayerHelper.MediaState.REACHED_END)
				{
					// Pause other videos before playing this one
					PauseOtherVideos(video);

					// Play this video from the beginning
					video.VideoPlayer.Play(false, 0);
				}
			}
		}

		mHasBeenFound = true;
		mLostTracking = false;
	}	

    private void OnTrackingLost()
	{   PauseallOtherVideos(video);
		hide_target ();
        Renderer[] rendererComponents = GetComponentsInChildren<Renderer>();
        Collider[] colliderComponents = GetComponentsInChildren<Collider>();

        // Disable rendering:
        foreach (Renderer component in rendererComponents)
        {
            component.enabled = false;
        }

        // Disable colliders:
        foreach (Collider component in colliderComponents)
        {
            component.enabled = false;
        }
        mLostTracking = true;
        mSecondsSinceLost = 0;
        reset_camera ();
		PauseOtherVideos(video);
        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");

    }

	private void PauseallOtherVideos(VideoPlaybackBehaviour currentVideo)
	{
		VideoPlaybackBehaviour[] videos = (VideoPlaybackBehaviour[])
			FindObjectsOfType(typeof(VideoPlaybackBehaviour));

		foreach (VideoPlaybackBehaviour video in videos)
		{
			
				if (video.CurrentState == VideoPlayerHelper.MediaState.PLAYING)
				{
					video.VideoPlayer.Pause();
				}

		}
	}

    // Pause all videos except this one
    private void PauseOtherVideos(VideoPlaybackBehaviour currentVideo)
    {
        VideoPlaybackBehaviour[] videos = (VideoPlaybackBehaviour[])
                FindObjectsOfType(typeof(VideoPlaybackBehaviour));

        foreach (VideoPlaybackBehaviour video in videos)
        {
            if (video != currentVideo)
            {
                if (video.CurrentState == VideoPlayerHelper.MediaState.PLAYING)
                {
                    video.VideoPlayer.Pause();
                }
            }
        }
    }
    #endregion //PRIVATE_METHODS
}
