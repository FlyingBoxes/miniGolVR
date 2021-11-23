using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper: MonoBehaviour 
{
    public static ScoreKeeper SK;

    public static int numPlayers = 0;
    public static int numHoles = 0;

    public static int[,] scores = new int[4, 18];
    public static int score;

    void Awake()
    {
        if (SK != null)
        {
            GameObject.Destroy(SK);
        }
        else
        {

            SK = this;
        }

        DontDestroyOnLoad(this);
    }

    public static void printScore ()
    {
        for (int i = 0; i < numPlayers; i++)
        {
            for (int j = 0; j < numHoles; j++)
            {
                Debug.Log("Player #: " + i.ToString() + "Hole #: " + j.ToString() + "\t" + "Score: " + scores[i, j].ToString());
            }
        }
    }
}
