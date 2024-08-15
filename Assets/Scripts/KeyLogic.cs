using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PickUpLogic))]
public class KeyLogic : MonoBehaviour
{

    public bool IsHasKey { get; set; }
     
    public Action OpenAction {  get; set; }
    public PickUpLogic pickUpLogic {  get; set; }

    public UnityEvent OpenActionUnityEvent;

    public void Start()
    {
       pickUpLogic = GetComponent<PickUpLogic>();
        pickUpLogic.OnPickedUp += KeyPickUp;
    }

    public void KeyPickUp()
    {
        IsHasKey = true;
    }
    public void DoorOpen()
    {
        if (IsHasKey)
        {
            OpenAction?.Invoke();
            OpenActionUnityEvent?.Invoke();
        }

        else
        {
            Debug.Log("You don't have key");
        }
    }


}
