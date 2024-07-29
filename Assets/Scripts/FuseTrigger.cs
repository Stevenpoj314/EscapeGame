using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FuseTrigger : MonoBehaviour
{
    public Animator FuseObject;
    public GameObject fuse;
    public BoxCollider FuseBox;

    public void OnTriggerEnter(Collider other)
    {
      
        fuse.SetActive(true);

        FuseObject.SetBool("Start", true);

        FuseBox.enabled = false;
        
    }
}
