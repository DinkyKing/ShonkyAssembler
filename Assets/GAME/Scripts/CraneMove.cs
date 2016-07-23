using UnityEngine;
using System.Collections;

public class CraneMove : MonoBehaviour {

	public float craneSpeed = 1f;
	static public Vector3 playerPos = new Vector3(0, 7.5f, 2);

	void Start () {
		if (Debugger.debugMode == true) {
			Debug.Log ("Crane Mover Started");
		}
	}
	
	void Update () {
		float xPos = transform.position.x + (Input.GetAxis("Horizontal") * craneSpeed);
		playerPos = new Vector3(Mathf.Clamp(xPos, -10.0f, 10.0f), 7.5f, 2f); // Clamp is the size of the floor
		transform.position = playerPos;
	}
}
