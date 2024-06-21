using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLogic : MonoBehaviour
{
    public GameObject Key;

    private void OnTriggerEnter(Collider Player)
    {
        Debug.Log("Press space to pick up Key");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(Key);
        }
    }
}
