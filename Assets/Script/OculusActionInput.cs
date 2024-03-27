using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class OculusActionInput : MonoBehaviour
{
    //Action Asset
    public InputActionAsset InputActions;
    //Action Reference
    public InputActionReference ActivateReference;

    private void OnEnable()
    {
        InputActions.Enable();
        ActivateReference.action.performed += ActivateButton;
    }

    private void ActivateButton(InputAction.CallbackContext callbackContext)
    {
        Debug.Log("PrimaryButton");
    }

    private void OnDisable()
    {
        InputActions.Disable();
        ActivateReference.action.performed += ActivateButton;
    }
}
