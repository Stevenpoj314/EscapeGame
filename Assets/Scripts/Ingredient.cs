using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
   

   
   
    public void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        GameController.Instance.IngredientsCounter++;
        Destroy(gameObject);



        //cauldron.SetBool("Open", true);

      
    }

    
}
