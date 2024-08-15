using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FuseTrigger : MonoBehaviour
{
    public Animator FuseAnimator;
    public GameObject FuseObject;
    public BoxCollider FuseBox;

    public void OnTriggerEnter(Collider other)
    {
      
        FuseObject.SetActive(true);

        FuseAnimator.SetTrigger("AnimationStart");

        FuseBox.enabled = false;
        
    }
}
