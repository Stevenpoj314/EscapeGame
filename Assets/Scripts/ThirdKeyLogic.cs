using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdKeyLogic : MonoBehaviour
{
    public GameObject ThirdKey;

    public void OnTriggerEnter(Collider other)
    {
        GameController.Instance.HasThirdKey = true;
        Destroy(ThirdKey);

       
    }
}
