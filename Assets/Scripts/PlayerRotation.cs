using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Transform cameraObject;
    public float rotationSpeed;
    public float mouseSensitivity = 100f;
    float xRotation = 0f;
    public float minAngle;
    public float maxAngle;

    private bool isRotate;
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void SetPlayerRotate()
    {
        isRotate = true;
    }

    void Update()
    {
        if (isRotate)
        {
            PlayerRotate();
        }

    }

    private void PlayerRotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, minAngle, maxAngle);
        xRotation = MyClamp(xRotation, minAngle, maxAngle);


        cameraObject.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

    private float MyClamp(float TargetVal, float minVal, float maxVal)
    {
        if (TargetVal < minVal)
        {
            return minVal;
        }

        else if (TargetVal > maxVal)
        {
            return maxVal;
        }

        return TargetVal;

    }
}
