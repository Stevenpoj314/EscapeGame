using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondKeyLogic : MonoBehaviour
{
    public GameObject Secondkey;
    public void OnTriggerEnter(Collider other)
    {
        GameController.Instance.IsChestOpen = true;
        Destroy(Secondkey);
    }
}
