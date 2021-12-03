using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public static GameMaster GM;
    public static string [] holes = {"Hole 1", "Hole 2", "Hole 3", "Hole 4", "Hole 5", "Hole 6", "Hole 7", "Hole 8", "Hole 9",
                                     "Hole 10", "Hole 11", "Hole 12", "Hole 13", "Hole 14", "Hole 15", "Hole 16", "Hole 17", "Hole 18"};
    public static int sceneIndex = 0;
    public static int maxHole = 0;

    void Awake()
    {
        if (GM != null)
        {
            GameObject.Destroy(GM);
        }
        else
        {

            GM = this;
        }

        DontDestroyOnLoad(this);
    }

    public static void LoadNextScene()  
    {
        if (sceneIndex > maxHole)
        {
            SceneManager.LoadScene("Start Menu");
        }
        else
        {
            SceneManager.LoadScene(holes[sceneIndex]);
        }
    }
}
