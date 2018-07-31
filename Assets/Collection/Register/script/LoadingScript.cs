using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour {


		AsyncOperation sceneAO;
		public GameObject loadingUI;
		
		public Text loadingText;

		// the actual percentage while scene is fully loaded
		private const float LOAD_READY_PERCENTAGE = 0.9f;
		void Start()
		{
		loadingUI.SetActive(false);
		}
		public void ChangeScene(string sceneName){
			loadingUI.SetActive(true);
		    loadingText.text = "LOADING...............\nPlease Wait..";
			StartCoroutine(LoadingSceneRealProgress(sceneName));
		}

		IEnumerator LoadingSceneRealProgress(string sceneName) {
			//yield return new WaitForSeconds(1);
			sceneAO = SceneManager.LoadSceneAsync(sceneName);

			// disable scene activation while loading to prevent auto load
			sceneAO.allowSceneActivation = false;

			while (!sceneAO.isDone) {
				{
					
                    sceneAO.allowSceneActivation = true;
					
				}
				//Debug.Log(sceneAO.progress);
				yield return null;
			}
		}
	}

