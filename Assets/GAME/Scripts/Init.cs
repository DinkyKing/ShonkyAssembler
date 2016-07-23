using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour {

	void Start () {
		if (Debugger.debugMode == true) {
			Debug.Log("Init Started");
		}
		SceneManager.LoadScene("Splash");
	}
}
