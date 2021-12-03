using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SingleHole : MonoBehaviour
{
    [SerializedField] public Button singleHoleButton;
    void Start()
    {
        Button btn = singleHoleButton.GetComponent<Button>();
        btn.onClick.AddListener(singleHoleClicked);
    }

    // Update is called once per frame
    void singleHoleClicked()
    {
        GameMaster.maxHole = 0;
    }
}
