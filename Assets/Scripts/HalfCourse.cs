using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HalfCourse : MonoBehaviour
{
    [SerializedField] public Button halfCourseButton;
    void Start()
    {
        Button btn = halfCourseButton.GetComponent<Button>();
        btn.onClick.AddListener(HalfCourseClicked);
    }

    // Update is called once per frame
    void HalfCourseClicked()
    {
        GameMaster.maxHole = 8;
        SceneManager.LoadScene(GameMaster.holes[0]);
    }
}
