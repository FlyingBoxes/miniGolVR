using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static int numPlayers = 2;
    private static int numHoles = 6;

    public static int[,] scores = new int[numPlayers, numHoles];

    // increment score for a specific player on a specific hole number.
    public static void stroke(int player, int hole)
    {
        scores[player, hole] = scores[player, hole] + 1; 
    }
    
    public static void printScore(int player, int hole)
    {
        Debug.Log("Score: " + scores[player, hole].ToString());
    }
}
