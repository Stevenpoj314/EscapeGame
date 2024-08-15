using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestKeyLogic : MonoBehaviour
{
    public GameObject Key;
   
    public void OnTriggerEnter(Collider other)
    {
       GameController.Instance.HasChestKey = true;
       Destroy(Key);  
    }
}
