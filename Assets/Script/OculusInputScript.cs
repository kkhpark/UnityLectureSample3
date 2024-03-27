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
            //눌렀으면 참 안눌렀으면 거짓.
            //primary button은 x 혹은 a 버튼
            Debug.Log("Primary Button : " + primary);
        }

        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondary))
        {
            Debug.Log("secondary Button : " + secondary);
        }
        if (Controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out bool primary2DAxisClick))
        {//조이스틱에 손 올리면 터치 누르면 클릭 돌리면 이제 jog
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


        //trigger / grip 버튼은 누르는 강도가 있음.  체크 할 수도 있고 그냥 클릭 상태만 체크도 가능.
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
