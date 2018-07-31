using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject webplane;
	void Start () {
		//GameObject camParent = new GameObject ("CamParent");
		///camParent.transform.position = this.transform.position;
		//this.transform.parent = camParent.transform;
		//camParent.transform.Rotate(Vector3.right, 90);
		Input.gyro.enabled = true;
		WebCamTexture tx = new WebCamTexture ();
		webplane.GetComponent<MeshRenderer> ().material.mainTexture = tx;
		tx.Play ();
	}
	

}
