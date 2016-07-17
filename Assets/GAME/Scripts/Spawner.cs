using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public int blockType;

	void Update()
	{
		drop();
		selector();
	}

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
            Vector3 currentPos = new Vector3(CraneMove.playerPos.x, CraneMove.playerPos.y - 1, CraneMove.playerPos.z);
            BlockAgent blockClone = new BlockAgent(currentPos, blockType); // make a clone and drop it
        }
    }

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           