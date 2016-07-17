using UnityEngine;
using System.Collections;

public class Debugger : MonoBehaviour {

	public static bool debugMode = true;

	void Start () {
		if (Debugger.debugMode == true) {
			Debug.Log("Debugger Started");

		}
	}
}
