using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class CollideController : MonoBehaviour
{
    public GameObject rightHandController;

    public InputActionReference colliderActivationReference;

    public UnityEvent onColliderActivate;
    public UnityEvent onColliderCancel;

    private CollideController CC;

    void Awake()
    {
        if (CC != null)
        {
            GameObject.Destroy(CC);
        }
        else
        {

            CC = this;
        }

        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        colliderActivationReference.action.performed += ColliderModeActivate;
        colliderActivationReference.action.canceled += ColliderModeCancel;
    }

    private void ColliderModeCancel(InputAction.CallbackContext obj)
    {
        onColliderActivate.Invoke();
    }

    private void ColliderModeActivate(InputAction.CallbackContext obj)
    {
        if (CC != null)
        {
            Invoke("DeactivateCollider", .1f);
        }

    }

    void DeactivateCollider()
    {
        onColliderCancel.Invoke();
    }
}
