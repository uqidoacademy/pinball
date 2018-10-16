using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayUI : MonoBehaviour {

    public int score;
    public int lives;
    public bool GameOver = false;

    void OnGUI()
    {
        if (GameOver)
        {
            GUI.Label(new Rect(20, 20, Screen.width, Screen.height), "<size=30>Game over! Press R to Restart</size>");
        }
        GUI.contentColor = Color.red;
        GUI.Label(new Rect(20, 60, Screen.width, Screen.height),  "<size=30>Lives  = </size>" + "<size=30>" + lives + "</size>");
        GUI.Label(new Rect(20, 100, Screen.width, Screen.height), "<size=30>Score = </size>" + "<size=30>" + score + "</size>");


    }
}
