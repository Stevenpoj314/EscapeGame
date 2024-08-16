using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.Events;

public class DoorLogic : MonoBehaviour
{
    public float RotateAngle;
    public KeyLogic DoorKey;
    public bool IsPlayerNearTheDoor;
    public bool IsDoorOpened;
    public bool CanOpenDoor;
    public int direction;
    private Vector3 targetRotate;

    public void Start()
    {
        targetRotate = new Vector3(transform.eulerAngles.x, RotateAngle, transform.eulerAngles.z);
        DoorKey.OpenAction += DoorOpen;
    }
    private void OnTriggerEnter(Collider Player)
    {
        IsPlayerNearTheDoor = true;
        //Debug.Log("Press space to open");

    }

    private void OnTriggerExit(Collider other)
    {
        IsPlayerNearTheDoor = false;
    }

    private void Update()
    {
        if (IsPlayerNearTheDoor && Input.GetKeyDown(KeyCode.Space))
        {
            CanOpenDoor = true;
        }
        if (IsPlayerNearTheDoor && CanOpenDoor && !IsDoorOpened)
        {
            DoorKey.DoorOpen();
            GetComponent<BoxCollider>().enabled = false;
            if (Mathf.RoundToInt(transform.eulerAngles.y) == RotateAngle)
            {
                IsPlayerNearTheDoor = false;
                IsDoorOpened = true;
                CanOpenDoor = false;
            }
        }
    }

    /*private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            DoorKey.DoorOpen();
        }

        else
        {
            Debug.Log("You don't have a key");
        }
    }*/

    private void DoorOpen()
    {
        transform.Rotate(new Vector3(transform.eulerAngles.x, RotateAngle * direction, transform.eulerAngles.z) * Time.deltaTime);
        
        //StartCoroutine(DoorRotate());
    }


    //private IEnumerator DoorRotate()
    //{
    //    var endRotation = Math.Abs(Mathf.Abs(transform.eulerAngles.y) - Mathf.Abs(RotateAngle));
    //    var tempAngle = Vector3.zero;

        

    //    if (RotateAngle > transform.eulerAngles.y)
    //    {
    //        while (RotateAngle > transform.eulerAngles.y)
    //        {
    //            Vector3.RotateTowards(transform.eulerAngles, targetRotate, 1, 0.0f);
    //            tempAngle.y += 1;
    //            transform.eulerAngles += tempAngle;
    //            yield return null;
    //        }
            
    //    }
    //    else if (RotateAngle < transform.eulerAngles.y)
    //    {
    //        while (RotateAngle < transform.eulerAngles.y)
    //        {
    //            tempAngle.y -= 1;
    //            transform.eulerAngles -= tempAngle;
    //            yield return null;
    //        }
            
    //    }

    //    /*for (float i = 0; i < RotateAngle; i++)
    //    {
            
    //        //transform.eulerAngles = new Vector3(transform.eulerAngles.x, i, transform.eulerAngles.z);
    //        //transform.Rotate(Vector3.up, RotateAngle * direction);
    //        //transform.rotation = new Vector3(transform.rotation.x, i, transform.rotation.z);
    //        //transform.Rotate(transform.rotation.x, i, transform.rotation.z);
    //        yield return null;
    //        Debug.Log("ROTATE");

    //    }*/


    //}
}
