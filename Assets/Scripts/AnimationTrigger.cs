using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject Ingredients;
    public Animator Cauldron;
    public BoxCollider TriggerCollider;
    

    private void OnTriggerEnter(Collider other)
    {
        Ingredients.SetActive(true);

        Cauldron.SetBool("Open", true); 
        
        TriggerCollider.enabled = false;
    }
   
}
