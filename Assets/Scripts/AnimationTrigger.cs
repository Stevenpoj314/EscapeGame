using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject Ingredients;
    public Animator Cauldron;
    public BoxCollider TriggerCollider;
    public GameObject FinalIngredients;

    private void OnTriggerEnter(Collider other)
    {
        if(GameController.Instance.IngredientsPotionCounter == 4)
        {
          Ingredients.SetActive(true);

          Cauldron.SetBool("Open", true); 
        
          TriggerCollider.enabled = false;


            Debug.Log("FirstPotionReady");

        }

        else if (GameController.Instance.ItemsCounter == 4)
        {
            FinalIngredients.SetActive(true);

            Cauldron.SetBool("Open", true);

            TriggerCollider.enabled = false;


            Debug.Log("SecondPotionReady");
        }
    }
   
}
