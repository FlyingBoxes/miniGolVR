using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FullCourse : MonoBehaviour
{
    [SerializedField] public Button FullCourseButton;
    void Start()
    {
        Button btn = FullCourseButton.GetComponent<Button>();
        btn.onClick.AddListener(FullCourseClicked);
    }

    // Update is called once per frame
    void FullCourseClicked()
    {
        GameMaster.maxHole = 17;
        SceneManager.LoadScene(GameMaster.holes[0]);
    }
}
