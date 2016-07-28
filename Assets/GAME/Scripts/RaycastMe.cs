using UnityEngine;
using System.Collections;

[ExecuteInEditMode]

public class RaycastMe : MonoBehaviour {

	RaycastHit hit;
	float range = 10.0f;
    bool dropped = false;
    int count = 0;

    // Update is called once per frame
    void Update () {
        showRay();
	}

	void showRay()
	{
        if (Physics.Raycast(transform.position, transform.forward, out hit, range) && hit.rigidbody.velocity == Vector3.zero && dropped == false) {
            dropped = true;
            count++;
            Debug.Log(count); // count is the amount of checks
		}
        if (Physics.Raycast(transform.position, transform.forward, out hit, range) && hit.rigidbody.velocity != Vector3.zero && dropped == true) // stop looping intensive work until another block has been detected
        {
            dropped = false;
        }
	}
}
