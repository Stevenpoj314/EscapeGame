using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionTeleport : MonoBehaviour
{
    public Transform TeleportTransform;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerControl>())
        {
            GameController.Instance.player.PlayerTeleport(TeleportTransform);
            Destroy(gameObject); 
        }
    }
}
