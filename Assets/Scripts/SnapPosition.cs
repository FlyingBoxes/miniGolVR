using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapPosition : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        
        other.transform.parent.position = transform.position;
        Debug.Log("Hitting trigger");
    }
}
