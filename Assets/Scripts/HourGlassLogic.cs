using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourGlassLogic : MonoBehaviour
{
    public GameObject Hourglass;

    public void OnTriggerEnter(Collider other)
    {
        GameController.Instance.IsHasHourglass = true;
        Destroy(gameObject);
    }
}
