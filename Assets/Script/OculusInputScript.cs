using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;


public class OculusInputScript : MonoBehaviour
{

    public XRController Controller;
    public ActionBasedController ActionController;

    // Update is called once per frame
    void Update()
    {
        CommonInput();
    }

    void CommonInput()
    {
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primary))
        {
            //�������� �� �ȴ������� ����.
            //primary button�� x Ȥ�� a ��ư
            Debug.Log("Primary Button : " + primary);
        }

        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondary))
        {
            Debug.Log("secondary Button : " + secondary);
        }
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out bool primary2DAxisClick))
        {//���̽�ƽ�� �� �ø��� ��ġ ������ Ŭ�� ������ ���� jog
            Debug.Log("primary2DAxisClick Button : " + primary2DAxisClick);
        }
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxisTouch, out bool primary2DAxisTouch))
        {
            Debug.Log("primary2DAxisTouch Button : " + primary2DAxisTouch);
        }
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxis))
        {
            Debug.Log("primary2DAxis position : " + primary2DAxis);
        }


        //trigger / grip ��ư�� ������ ������ ����.  üũ �� ���� �ְ� �׳� Ŭ�� ���¸� üũ�� ����.
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerButton))
        {
            Debug.Log("triggerButton Button : " + primary2DAxis);
        }

        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.trigger, out float trigger))
        {
            Debug.Log("trigger amount : " + trigger);
        }

        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool gripButton))
        {
            Debug.Log("gripButton Button : " + gripButton);
        }

        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.grip, out float grip))
        {
            Debug.Log("grip amount : " + grip);
        }
    }
}
