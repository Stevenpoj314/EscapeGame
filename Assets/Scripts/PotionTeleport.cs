using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PotionTeleport : MonoBehaviour
{
    public Transform TeleportTransform;
    public UnityEvent OnTeleported;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerControl>())
        {
            GameController.Instance.player.PlayerTeleport(TeleportTransform);
            OnTeleported?.Invoke();
            Destroy(gameObject);
          

        }

       
           
        
    }
}
