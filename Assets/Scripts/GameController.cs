using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GameController: MonoBehaviour



{
    public static int score = 0;
    public static int npcScore = 0;
    public void OnCubeGrabbed()
    {
        npcScore--;
        // Update the score on your GUI...
    }

    void OnGUI()
    {
        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.fontSize = 24;
        scoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 200, 50), "Player Score: " + score, scoreStyle);
        GUI.Label(new Rect(10, 40, 200, 50), "NPC Score: " + npcScore, scoreStyle);
    }






}
