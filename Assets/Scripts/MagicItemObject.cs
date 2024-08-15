using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicItemObject : MonoBehaviour
{
    public Action OnItemGot;
    public void OnTriggerEnter(Collider other)
    {
        OnItemGot?.Invoke();
        Destroy(gameObject);
    }
}
