using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera CameraBehind;
    public Camera CameraDriver;

    //true or false for CameraToggle Button
    private bool cameraToggle;

    public void UseCameraBehind()
    {
        CameraBehind.enabled = true;
        CameraDriver.enabled = false;

    }

    public void UseCameraDriver()
    {
        CameraBehind.enabled = false;
        CameraDriver.enabled = true;
    }

    public void CameraToggle()
    {
        if (CameraBehind.enabled == true)
        {
            UseCameraDriver();
            return;
        }
        else if (CameraDriver.enabled == true)
        {
            UseCameraBehind();
            return;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Set the camera to Driver
        UseCameraDriver();
    }

    // Update is called once per frame
    void Update()
    {
        cameraToggle = Input.GetButtonDown("Fire1");

        if (cameraToggle == true)
        {
            CameraToggle();
        }
    }


}

