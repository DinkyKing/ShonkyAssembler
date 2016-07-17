using UnityEngine;
using System.Collections;

public class Crane : MonoBehaviour
{
    public float craneSpeed = 1f;
    public Vector3 playerPos = new Vector3(0, 7.5f, 2);

    public int blockType;

    void selector()
    {
        if (Input.GetKeyDown(KeyCode.E)) // cycle through objects
        {
            blockType++;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            blockType--;
        }
    }

    void drop() // The shape dropper 
    {
        if (Input.GetKeyDown("space"))
        {
            Vector3 currentPos = new Vector3(playerPos.x, playerPos.y - 1, playerPos.z);
            BlockAgent blockClone = new BlockAgent(currentPos, blockType); // make a clone and drop it
        }
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * craneSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -10.0f, 10.0f), 7.5f, 2f); // Clamp is the size of the floor
        transform.position = playerPos;
        drop();
        selector();
    }

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           