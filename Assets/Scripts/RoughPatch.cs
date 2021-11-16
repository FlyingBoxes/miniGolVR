using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoughPatch : MonoBehaviour
{
    [SerializeField] private float _roughMultiplier = 0.6f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Vector3 v1 = other.GetComponent<Rigidbody>().velocity;
            other.GetComponent<Rigidbody>().velocity = v1 * _roughMultiplier;
        }

    }
}
