using UnityEngine;
using System.Collections;

[ExecuteInEditMode]

public class RaycastMe : MonoBehaviour {

	RaycastHit hit;
	float range = 10.0f;

    // Update is called once per frame
    void Update () {
		showRay ();
	}

	void showRay()
	{
		if (Physics.Raycast (transform.position, transform.forward, out hit, range)) {
			Debug.Log ("ray hit object" + hit.transform.name);
			Debug.DrawRay (transform.position, transform.forward, Color.red, 1);
		} 
	}
}
