using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTrigger : MonoBehaviour
{
    public GameObject FireBoy;
    public Animator Hand;
    public BoxCollider HandCollider;
    public GameObject Wand;
   
    private void OnTriggerEnter(Collider other)
    {
        if (GameController.Instance.MagicItemsCounter == 2)
        {
            FireBoy.SetActive(true);

            Hand.SetBool("Closed", true);

            HandCollider.enabled = false;

            

        }

        else if (GameController.Instance.WandMaterialCounter == 5)
        {
            Wand.SetActive(true);

            Hand.SetBool("Closed", true);

            HandCollider.enabled = false;

           
        }

        //if (GameController.Instance.MagicItemsCounter == 2)
        //{

        //    GameController.Instance.IsHasMagicItems = true;
        //    GameController.Instance.MagicItemsCounter = 0;
        //}

        //else if (GameController.Instance.WandMaterialCounter == 5)
        //{
        //    GameController.Instance.IsHasWand = true;
        //    GameController.Instance.WandMaterialCounter = 0;
        //}
    }
}
