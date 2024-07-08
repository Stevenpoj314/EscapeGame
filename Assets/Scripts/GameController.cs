using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Animator Cauldron;
    public Animator Ingredients;
    public static GameController Instance;
    public bool IsCauldronHasIngredient;
    public MyTimer mytimer;
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
}
