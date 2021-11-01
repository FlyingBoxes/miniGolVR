using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableObject : MonoBehaviour
{
    [SerializeField]
    LayerMask layerMask;

    [SerializeField]
    private float _heightToBase = 0.17f;
    private bool _isPlaced = false;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, layerMask) && !_isPlaced)
        {
            transform.position = new Vector3(hit.point.x, hit.point.y + _heightToBase, hit.point.z);
            // transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            RunMouseEvent();
        }
    }

    private void RunMouseEvent()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isPlaced = true;
        } else if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(Vector3.up, 90f);
        }
    }
}
