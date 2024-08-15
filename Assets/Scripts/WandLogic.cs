using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandLogic : MonoBehaviour
{
    public GameObject wand;

    public void OnTriggerEnter(Collider other)
    {
       
            Destroy(wand);

        
        
    }

}
