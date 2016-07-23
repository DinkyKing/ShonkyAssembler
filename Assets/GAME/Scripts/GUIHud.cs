using UnityEngine;
using System.Collections;

public class GUIHud : MonoBehaviour
{
    public Texture2D BoxTexture;

    public Texture2D cubeT;
    public Texture2D beamT;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // cycle through objects
        {
            BoxTexture = cubeT;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            BoxTexture = beamT;
        }
    }

    void OnGUI()
    {
            GUI.Box(new Rect(0, 0, Screen.width / 10, Screen.width / 10), BoxTexture); // 120 is the middle of the box for both x and y
    }
}

