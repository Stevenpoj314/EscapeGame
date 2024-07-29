using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Animator Cauldron;
    public Animator Ingredients;
    public static GameController Instance;
    public bool IsCauldronHasIngredient;
    public MyTimer mytimer;
    public GameObject PotionBottle;
    public bool IsPotionReady;
    public GameObject[] ingredient;
    public int IngredientsCounter;
    public BoxCollider TeleportTrigger;
    public PlayerControl player;
    public bool HasFirstKey;
    public GameObject[] Items;
    public int ItemsCounter;
    public bool IsHasFuse;
    public Animator FuseBox;
   
    public void BrewingTimer(float TimeBrewing)
    {
        StartCoroutine(mytimer.StartTimer(TimeBrewing));
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Update()
    {
       
        

        if (IngredientsCounter == 4)
        {
            TeleportTrigger.enabled = true;
            IngredientsCounter = 0;


        }
    }


    
}
