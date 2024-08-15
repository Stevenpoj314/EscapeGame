using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShrinkPotion : MonoBehaviour
{
    public GameObject PotionBottle;
    public GameObject BrokenPotion;

    public void OnTriggerEnter(Collider other)
    {
        if (GameController.Instance.IsHasHourglass)
        {
            Destroy(BrokenPotion);
            PotionBottle.SetActive(true);
            GameController.Instance.IsHasShrinkPotion = true;
        }
    }
}
