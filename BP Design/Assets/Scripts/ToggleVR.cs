using System.Collections;
using System;
using UnityEngine;
using UnityEngine.XR;

public class ToggleVR : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (XRSettings.loadedDeviceName == "cardboard")
            {
                StartCoroutine(LoadDevice("None"));
            }
            else
            {
                Application.Quit();
            }
        }
    }

    public void vrToggle()
    {
        if(XRSettings.loadedDeviceName == "cardboard")
        {
            StartCoroutine(LoadDevice("None"));
            //GameObject.Find("/Player/RigidBodyFPSController/MainCamera").GetComponent<TouchPosition>().layerMask = -1;
        }
        else
        {
            //GameObject.Find("/Player/RigidBodyFPSController/MainCamera").GetComponent<TouchPosition>().layerMask = ~(1 << 9 | 1 << 8);
            StartCoroutine(LoadDevice("cardboard"));
        }
    }

    IEnumerator LoadDevice(string newDevice)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        XRSettings.enabled = true;
    }
}
