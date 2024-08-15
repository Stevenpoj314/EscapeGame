using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class IngredientPotion : MonoBehaviour
{
   

   
   
    public void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        GameController.Instance.IncreasePotionIngredientAmount();
        Destroy(gameObject);



        //cauldron.SetBool("Open", true);

      
    }

    
}
