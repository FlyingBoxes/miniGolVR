using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LeftTestActionController : MonoBehaviour
{
    private ActionBasedController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();

        // basic way of storing input. Stores it within a variable.
        bool isPressed = controller.selectAction.action.ReadValue<bool>();

        // add function (Action_perfomed) to a list of functions to be perfromed once input is detected.
        controller.selectAction.action.performed += Select_perfomed;
        controller.selectAction.action.performed += Activate_Rumble;
    }

    private void Select_perfomed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Debug.Log("Left Select Button Pressed");
    }

    private void Activate_Rumble(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Debug.Log("Left Rumble Activated");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
