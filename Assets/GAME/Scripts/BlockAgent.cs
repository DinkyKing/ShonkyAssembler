using UnityEngine;
using System.Collections;

public class BlockAgent : MonoBehaviour {

    public Vector3 blockPos; // The position to be added
    public int blockType; // Which shape is it?

	public GameObject blockPrefab;

    public BlockAgent(Vector3 pos, int type)
    {
        blockPos = pos;
        blockType = type; //Parse the variables

		switch (blockType)
		{

		case 1:
			blockPrefab = (GameObject)Instantiate(Resources.Load("cubePrefab")); // load it to be dropped
			blockPrefab.transform.position = blockPos; // place is
			break;
		case 2:
			blockPrefab = (GameObject)Instantiate(Resources.Load("beamPrefab"));
			blockPrefab.transform.position = blockPos;
			break;
		default:
			print ("zero");
			break;
		}        

    }
}
	
/*if (blockType == 1) // square
{
	GameObject blockPrefab = (GameObject)Instantiate(Resources.Load("cubePrefab")); // load it to be dropped
	blockPrefab.transform.position = blockPos; // place is         
}
if (blockType == 2) // beam
{
	GameObject blockPrefab = (GameObject)Instantiate(Resources.Load("beamPrefab"));
	blockPrefab.transform.position = blockPos;
} */