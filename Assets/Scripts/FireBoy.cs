using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireBoy : MonoBehaviour
{
    public GameObject FireItem;

    public void OnTriggerEnter(Collider other)
    {
        Destroy(FireItem);
    }
}

