using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CourseBuilderUIController : MonoBehaviour
{
    public Button addStartBtn;
    public Button addStraightBtn;
    public Button addCrossingBtn;
    public Button addHoleBtn;
    public Button addTunnelBtn;
    public Button addHillBtn;
    public Button addTriangleBtn;
    
    // Tracks Prefabs 
    public GameObject startPrefab;
    public GameObject straightPrefab;
    public GameObject crossingPrefab;
    public GameObject holePrefab;
    
    // Obstacles/Gimmicks Prefabs 
    public GameObject trianglePrefab;
    public GameObject hillPrefab;
    public GameObject tunnelPrefab;
    
    
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        addStartBtn = root.Q<Button>("add-start-btn");
        addStraightBtn = root.Q<Button>("add-straight-btn");
        addCrossingBtn = root.Q<Button>("add-crossing-btn");
        addHoleBtn = root.Q<Button>("add-hole-btn");
        addTunnelBtn = root.Q<Button>("add-tunnel-btn");
        addHillBtn = root.Q<Button>("add-hill-btn");
        addTriangleBtn = root.Q<Button>("add-triangle-btn");

        addStartBtn.clicked += AddSartBtnClicked;
        addStraightBtn.clicked += AddStraightBtnClicked;
        addCrossingBtn.clicked += AddCrossingBtnClicked;
        addHoleBtn.clicked += AddHoleBtnClicked;
        addTunnelBtn.clicked += addTunnelBtnClicked;
        addHillBtn.clicked += AddHillBtnClicked;
        addTriangleBtn.clicked += AddTriangleBtnClicked;
    }

    private void addTunnelBtnClicked()
    {
        Instantiate(tunnelPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    private void AddHillBtnClicked()
    {
        Instantiate(hillPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    private void AddTriangleBtnClicked()
    {
        Instantiate(trianglePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    private void AddSartBtnClicked()
    {
        Instantiate(startPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void AddStraightBtnClicked()
    {
        Instantiate(straightPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
    
    void AddCrossingBtnClicked()
    {
        Instantiate(crossingPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
    
    void AddHoleBtnClicked()
    {
        Instantiate(holePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
