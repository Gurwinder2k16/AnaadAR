using UnityEngine;
using System.Collections;
using Vuforia;

public class FocusMode : MonoBehaviour {
	
	void Start () {
		
		//bool focusModeSet = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		//bool flash=CameraDevice.Instance.SetFlashTorchMode(true);
	//	if (!focusModeSet )
	//	{
			Debug.Log("Failed to set focus mode (unsupported mode)."); 
		//	CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
	//	}
     
	}
}