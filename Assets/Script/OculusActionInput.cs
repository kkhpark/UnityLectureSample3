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




    // �� ���
    void FireBullet()
    {
        GameObject bullet = Instantiate(Bullet);
        //��Ʈ�ѷ����� ���� �ٶ󺸴� �������� �Ѿ��� ������ ��.
        bullet.transform.position = transform.position; //���� ��ũ��Ʈ�� ���� �Ǿ� �ִ� GameObject(Controller)�� ��ġ�� �״�� ���ٴ°Ű���.
        bullet.transform.rotation = transform.rotation;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);

    }
}
