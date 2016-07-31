using UnityEngine;
using System.Collections;

public class KinCollider : MonoBehaviour
{
    public static bool hasStopped = true; // is the object kinematic?

    public static bool hasRolling = false;
    public static int rotNum;


    void Update()
    {
        if (gameObject.GetComponent<Rigidbody>().rotation.eulerAngles.y > 10)
        {
            Debug.Log("my rotation is more than 10");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Rigidbody>().velocity.x <= 0.0001f
            && col.gameObject.GetComponent<Rigidbody>().velocity.y <= 0.0001f)
        {
            //col.gameObject.GetComponent<Rigidbody>().isKinematic = true; // set it to kinematic
            hasStopped = true; // it has fully dropped and can now go back to dropping more objects
        }
    }
}
