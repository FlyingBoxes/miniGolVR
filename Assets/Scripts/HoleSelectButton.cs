using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoleSelectButton : MonoBehaviour
{
    [SerializedField] public Button holeButton;
    void Start()
    {
        Button btn = holeButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadHoleOnClick);
    }

    void LoadHoleOnClick()
    {
        String holeName = holeButton.GetComponentInChildren<Text>().text;
        Debug.Log(holeName);
        SceneManager.LoadScene(holeName);

    }
}
