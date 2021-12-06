using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MultiplayerSingleHoleMenu : MonoBehaviour
{
    public void PlayHole()
    {
        ScoreKeeper.numHoles = 1;
        ScoreKeeper.numPlayers = PlayerPrefs.GetInt("players");
        SceneManager.LoadScene("Hole Template");
        Debug.Log("Players: " + PlayerPrefs.GetInt("players") + "\t" + "Holes: " + ScoreKeeper.numHoles);
    }
}
