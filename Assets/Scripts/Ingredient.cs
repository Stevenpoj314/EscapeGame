using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    private BoxCollider ColliderTrigger;

    public Transform TeleportPlace;
    //public Animator cauldron;
    public GameObject Ingredients;
   
    public void Start()
    {
        ColliderTrigger = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        ColliderTrigger.enabled = false;
        transform.position = TeleportPlace.position;

        //cauldron.SetBool("Open", true);

       Ingredients(GameObject.SetActive(true));
    }

    
}
