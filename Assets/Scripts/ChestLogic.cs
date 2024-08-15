using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLogic : MonoBehaviour
{
    public Animator Chest;
    public Collider ChestCollider;
    public Collider KeyCollider;
    public void OnTriggerEnter(Collider other)
    {
        if (GameController.Instance.HasChestKey)
        {
            Chest.SetTrigger("ChestOpen");

            ChestCollider.enabled = false;
            KeyCollider.enabled = true;
        }
    }
}
