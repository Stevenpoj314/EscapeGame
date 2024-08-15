using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerLogic : MonoBehaviour
{
    public Animator Closet1;
    public Collider ClosetCollider;
    public GameObject Key;
    public Collider KeyCollider;

    public void OnTriggerEnter(Collider other)
    {
       Closet1.SetBool("DrawerOpen", true);
       ClosetCollider.enabled = false;
        GameController.Instance.IsDrawerOpen = true;

        if (GameController.Instance.IsDrawerOpen)
        {
            Debug.Log("DrawerClose");
            KeyCollider.enabled = true;
            GameController.Instance.IsHasDrawerKey = true;
            //Closet1.SetBool("DrawerOpen", false);
        }
          
    }
}
