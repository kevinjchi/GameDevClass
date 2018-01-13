using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public GUISkin skin;

    void OnGUI()
    {
        GUI.skin = skin;
        if(GUI.Button(new Rect(140, 10, (Screen.width - 260), 100), "PLAY GAME")) // Play is on the screen
        {
            Application.LoadLevel(0);
        }
        if(GUI.Button(new Rect(140, 120,(Screen.width - 260), 100), "QUIT GAME")) // Play is on the screen
        {
            Application.Quit();
        }
    }
}