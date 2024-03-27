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
    public InputActionReference PrimaryActionReference;

    public InputActionReference SecondaryActionReference;

    public InputActionReference TriggerActionReference;


    //Fire Bullet
    public GameObject Bullet;
    public float bulletSpeed;


    private void OnEnable()
    {
        InputActions.Enable();
        TriggerActionReference.action.performed += OnTriggerAction;
    }

    private void OnTriggerAction(InputAction.CallbackContext callbackContext)
    {
        Debug.Log("TriggerButton : " + callbackContext.ReadValue<float>());
        FireBullet();
    }

    private void OnDisable()
    {
        InputActions.Disable();
        TriggerActionReference.action.performed -= OnTriggerAction;
    }




    // 총 쏘기
    void FireBullet()
    {
        GameObject bullet = Instantiate(Bullet);
        //컨트롤러에서 내가 바라보는 방향으로 총알이 나가야 함.
        bullet.transform.position = transform.position; //지금 스크립트가 적용 되어 있는 GameObject(Controller)의 위치를 그대로 쓴다는거겠지.
        bullet.transform.rotation = transform.rotation;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);

    }
}
