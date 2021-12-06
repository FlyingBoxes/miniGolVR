using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSingleHoleMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayHole ()
    {
        ScoreKeeper.numHoles = 1; 
        SceneManager.LoadScene("Hole Template");
        Debug.Log("Players: " + ScoreKeeper.numPlayers + "\n" + "Holes: " + ScoreKeeper.numHoles);

    }
}
