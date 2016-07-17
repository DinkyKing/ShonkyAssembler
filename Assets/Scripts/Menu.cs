using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	void Start () {
		if (Debugger.debugMode == true) {
			Debug.Log("Menu Started");

		}
		SceneManager.LoadScene("Level");
	}

}
