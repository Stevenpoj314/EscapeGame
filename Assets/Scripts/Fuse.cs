using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    public GameObject fuse;
    public BoxCollider FuseBoxCollider;
    public void OnTriggerEnter(Collider other)
    {
        GameController.Instance.IsChestOpen = true;
          FuseBoxCollider.enabled = true;
          Destroy(fuse);

        
    }
}
