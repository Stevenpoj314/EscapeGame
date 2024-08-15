using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerControl>())
        {
            other.GetComponent<PlayerControl>().SetFlashLightActivity(true);
            Destroy(gameObject);
        }
    }
}
