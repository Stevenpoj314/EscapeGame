using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject Ingredients;
    public Animator Cauldron;

    private void OnTriggerEnter(Collider other)
    {
        Ingredients.SetActive(true);

        Cauldron.SetBool("Open", true);
    }
}
