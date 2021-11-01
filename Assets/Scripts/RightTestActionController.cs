using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RightTestActionController : MonoBehaviour
{
    private ActionBasedController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();

        // basic way of storing input. Stores it within a variable.
        bool isPressed = controller.selectAction.action.ReadValue<bool>();

        // call function (Action_perfomed) once input is detected.
        controller.selectAction.action.performed += Action_perfomed;
    }

    private void Action_perfomed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Debug.Log("Right Select Button Pressed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
