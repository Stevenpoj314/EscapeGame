using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandTrigger : MonoBehaviour
{
    public GameObject Wand;
    public Animator Hand;
    public BoxCollider HandCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (GameController.Instance.IsHasWandMaterial)
        {
         // Wand.SetActive(true);

          Hand.SetBool("Closed", true);

          HandCollider.enabled = false;

        }
    }
}
