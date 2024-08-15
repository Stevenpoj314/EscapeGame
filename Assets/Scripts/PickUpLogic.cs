using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickUpLogic : MonoBehaviour
{
    public Action OnPickedUp;
    public UnityEvent pickUp;

    public void OnTriggerEnter(Collider other)
    {
        OnPickedUp?.Invoke();
        pickUp?.Invoke();
        gameObject.SetActive(false);

    }
}
