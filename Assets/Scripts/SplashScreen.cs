using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

	void Start () {
		if (Debugger.debugMode == true) {
			Debug.Log("Splash Started");

		}
		SceneManager.LoadScene("Menu");
	}

}
