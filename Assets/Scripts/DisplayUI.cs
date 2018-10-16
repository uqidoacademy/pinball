using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayUI : MonoBehaviour {

    private int palline;
    private int score;
    private int lives;
    private bool gameOver = false;

    public int Palline
    {
        get{ return palline; }
        set{ palline = value; }
    }
    public int Score
    {
        get{ return score; }
        set{ score = value; }
    }
    public int Lives
    {
        get { return lives; }
        set { lives = value; }
    }
    public bool GameOver 
    {
        get { return gameOver; }
        set { gameOver = value; }
    }

    void OnGUI()
    {
        if (gameOver)
        {
            GUI.Label(new Rect(20, 20, Screen.width, Screen.height), "<size=30>Game over! Press R to Restart</size>");
        }
        GUI.contentColor = Color.red;
        GUI.Label(new Rect(20, 60, Screen.width, Screen.height),  "<size=30>Lives  = </size>" + "<size=30>" + lives + "</size>");
        GUI.Label(new Rect(20, 100, Screen.width, Screen.height), "<size=30>Score = </size>" + "<size=30>" + score + "</size>");
        GUI.Label(new Rect(20, 140, Screen.width, Screen.height), "<size=30>Palline = </size>" + "<size=30>" + palline + "</size>");    

    }
}
