using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float speedRotation;
    public float tempMousePos;
    public bool useCamRotation = false;
    
    void Start()
    {

    }

    void Update()
    {
        Quaternion cameraRot = transform.rotation;
        if (Input.GetMouseButtonDown(2))
        {
            tempMousePos = Input.mousePosition.x;
        }
        if (Input.GetMouseButton(2) && Input.mousePosition.x > tempMousePos - 1)
        {
            cameraRot.y += speedRotation;
        }
        if (Input.GetMouseButton(2) && Input.mousePosition.x < tempMousePos + 1)
        {
            cameraRot.y -= speedRotation;
        }
        if (useCamRotation == true)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, cameraRot, cameraRot.y);
        }
    }
}
