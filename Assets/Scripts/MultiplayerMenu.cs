using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplayerMenu : MonoBehaviour
{
    [SerializeField] Dropdown playersDropdown;
    public int playerNum;


    private void Start()
    {
        playersDropdown.onValueChanged.AddListener(delegate { DropDownValueChanged(playersDropdown); });
    }

    void DropDownValueChanged (Dropdown change)
    {
        ScoreKeeper.numPlayers = change.value + 2;
        Debug.Log("Number of Players changed to " + ScoreKeeper.numPlayers);
    }
}
