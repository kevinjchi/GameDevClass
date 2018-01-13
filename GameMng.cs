using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMng : MonoBehaviour
{
    public static int deathScore = 0;
    public static int highDeathScore;

    public static int currentLevel = 0;
    public static int unlockedLevel;

    //TIMER 
    //TODO MUST FIX TIMER UPDATER
    public Rect timerRect;
    public GUISkin skin;

    public float startTime; //starttime
    private string currentTime;

    void Upate()
    {
        startTime -= Time.deltaTime;
        currentTime = string.Format("{0:0.0}", startTime);
        print(currentTime);
        if (startTime <= 0)
        {
            startTime = 0;
            Application.LoadLevel(3); // Load level 3 if out of time
        }
    }
    

    public static void CompleteLevel() // static means dont need object reference
    {
        if (currentLevel < 2)// should i do length  levels?
        {
            currentLevel += 1;
            Application.LoadLevel(currentLevel);
        }
        else
        {
            print("You WIN!");
        }
    }

    void OnGui()
    {
        GUI.Label(timerRect, currentTime);
    }

   
}