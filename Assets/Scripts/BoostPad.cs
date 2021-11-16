using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPad : MonoBehaviour
{
    [SerializeField] private float _boostMultiplier = 3f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Vector3 v1 = other.GetComponent<Rigidbody>().velocity;
            other.GetComponent<Rigidbody>().velocity = v1 * _boostMultiplier;
        }

    }
}
