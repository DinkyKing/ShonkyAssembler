using UnityEngine;
using System.Collections;

public class KinCollider : MonoBehaviour
{
    public static bool hasStopped = false; // is the object kinematic?

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Rigidbody>().velocity == Vector3.zero)
        {
            col.gameObject.GetComponent<Rigidbody>().isKinematic = true; // set it to kinematic
            hasStopped = false; // it has fully dropped and can now go back to dropping more objects
        }
    }
}
