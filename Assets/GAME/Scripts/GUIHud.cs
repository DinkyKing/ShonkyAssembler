using UnityEngine;
using System.Collections;

public class GUIHud : MonoBehaviour {

    public Texture2D BoxTexture;

    public Texture2D cubeT; // Textures for Gui
    public Texture2D beamT;

    public int iconNum;


    public GUIHud(int blockNum)
    {
        iconNum = blockNum;
    }

    void OnGUI()
	{
		switch (iconNum) {

		case 1:
			BoxTexture = cubeT;
			GUI.Box (new Rect (0, 0, Screen.width / 10, Screen.width / 10), BoxTexture); // 120 is the middle of the box for both x and y
			break;
		case 2:
			BoxTexture = beamT;
			GUI.Box (new Rect (0, 0, Screen.width / 10, Screen.width / 10), BoxTexture); // 120 is the middle of the box for both x and y
			break;
		default:
			GUI.Box (new Rect (0, 0, Screen.width / 10, Screen.width / 10), BoxTexture); // 120 is the middle of the box for both x and y
			break;
		}  
	}

}

