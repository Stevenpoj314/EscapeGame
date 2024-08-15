using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.Events;

public class DoorLogic : MonoBehaviour
{
    public float StartRotate;
    public float EndRotate;
    public KeyLogic DoorKey;


    public void Start()
    {
        DoorKey.OpenAction += DoorOpen;
    }
    private void OnTriggerEnter(Collider Player)
    {
        //Debug.Log("Press space to open");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            DoorKey.DoorOpen();
        }

        else
        {
            Debug.Log("You don't have a key");
        }
    }

    private void DoorOpen()
    {
        StartCoroutine(DoorRotate());
    }

    private IEnumerator DoorRotate()
    {
        for (float i = StartRotate; i < EndRotate; i++)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, i, transform.rotation.z);
            //transform.Rotate(transform.rotation.x, i, transform.rotation.z);
            yield return null;
            
        }


    }       
}
