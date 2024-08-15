using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
   

    public void OnTriggerEnter(Collider other)
    {
        GameController.Instance.IncreaseItemAmount();
        Destroy(gameObject);
         
        
    }
}
