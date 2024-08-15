using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPotionLogic : MonoBehaviour
{
    public GameObject DoorPotion;
    
    public void OnTriggerEnter(Collider other)
    {
        GameController.Instance.IsHasDoorPotion = true;
        Destroy(DoorPotion);

       
    }
}
