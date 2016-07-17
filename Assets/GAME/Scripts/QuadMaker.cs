using UnityEngine;
using System.Collections;

public class QuadMaker : MonoBehaviour {

    public GameObject Quad;
    Vector3 spawnPos = new Vector3(-5.0f,-5.0f,4.5f); // default pos
	float rot = 0; // rotation for raycast

    void SpawnTemplate() // Makes the shapes for the template
    {
        for (int i = 0; i < 10; i++) // y axis
        {
            spawnPos.x = -5.0f; // reset x
            spawnPos.y++;

            for(int j = 0; j < 10; j++) // x axis
            {
                spawnPos.x++;
                Instantiate(Quad, spawnPos, Quaternion.Euler(new Vector3(0, rot, 0)));
            }
        }
        
    }

    void levelRef() // The game referee checks score and level progression
    {
        
    }

	// Use this for initialization
	void Start () {
        SpawnTemplate();
        levelRef();
	}
}
