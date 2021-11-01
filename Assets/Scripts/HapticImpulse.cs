using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticImpulse : MonoBehaviour
{
    [SerializeField] private ActionBasedController rightController;
    [SerializeField] private AudioSource putterSound;

    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            rightController.SendHapticImpulse(0.08f, .05f);
            putterSound.Play(0);
        }
        
    }
}
