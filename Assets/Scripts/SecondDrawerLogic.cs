using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDrawerLogic : MonoBehaviour
{
    public Animator SecondDrawer;
    public Collider SecondDrawerCollider;
    public GameObject Meat;
    public Collider MeatCollider;

    public void OnTriggerEnter(Collider other)
    {
        if (GameController.Instance.IsHasWand)
        {
            SecondDrawer.SetBool("BottomDrawerOpen", true);
            SecondDrawerCollider.enabled = false;
           MeatCollider.enabled = true;

        }
    }
}
