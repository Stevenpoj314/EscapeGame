using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Animator Cauldron;
    public Animator Ingredients { get; set; }
    public Animator PotionIngredients;
    public Animator DoorIngredients;
    public static GameController Instance;
    public bool IsCauldronHasIngredient;
    public MyTimer brewingTimer;
    public GameObject PotionBottle;
    public bool IsFirstPotionReady { get; set; }
    public bool IsSecondPotionReady;
    public GameObject[] ingredient;
    public int IngredientsPotionCounter;
    public BoxCollider TeleportTrigger;
    public PlayerControl player;
    public bool HasFirstKey;
    public GameObject[] Items;
    public int ItemsCounter;
    public int MagicItemsCounter;
    public MagicItem[] MagicItems;
    public Animator Hand;
    public GameObject FireBoy;
    public BoxCollider HandCollider;
    public bool IsHasMagicItems;
    public MyTimer HandTimer;
    public bool IsHasFireBoy;
    public bool HasChestKey { get; set; }
    public bool IsChestOpen;
    public bool IsHasFuse;
    public bool IsHasHourglass;
    public bool HasThirdKey;
    public bool IsHasShrinkPotion;
    public bool IsDrawerOpen;
    public Animator Closet1;
    public bool IsHasDrawerKey;
    public int WandMaterialCounter;
    public GameObject[] WandMaterials;
    public BoxCollider WandCollider;
    public bool IsHasWandMaterial;
    public GameObject Wand;
    public GameObject DoorPotion;
    public bool IsHasWand;
    public bool IsHasDoorPotion;
    public GameObject HandObject { get; set; }


    public void IncreasePotionIngredientAmount()
    {
        Instance.IngredientsPotionCounter++;
       

        if (Instance.IngredientsPotionCounter == 4)
        {
            Instance.Ingredients = PotionIngredients;
           Instance.TeleportTrigger.enabled = true;
        }

        

        
    }
    public void IncreaseItemAmount()
    {
        Instance.ItemsCounter++;
       

      

        if (Instance.ItemsCounter == 4)
        {
           Instance.Ingredients = DoorIngredients;
           Instance.TeleportTrigger.enabled = true;
        }

        
    }

    public void IncreaseMagicItemAmount()
    {
        Instance.MagicItemsCounter++;

        if (Instance.MagicItemsCounter == 2)
        {
            Instance.HandObject = FireBoy;
            Instance.HandCollider.enabled = true;
        }
    }

    public void IncreaseWandMaterial()
    {
        Instance.WandMaterialCounter++;

        if (Instance.WandMaterialCounter == 5)
        {
            Instance.HandObject = Wand;
            Instance.HandCollider.enabled = true;
        }
    }


    public void BrewingTimer(float TimeBrewing)
    {
        StartCoroutine(brewingTimer.StartTimer(TimeBrewing));
    }

    public void BrewingEnd()
    {
        Cauldron.SetBool("Open", true);
    }

    public void HandClosedTimer(float TimeClosed)
    {
        Debug.Log("HandClosedStart");
        StartCoroutine(HandTimer.StartTimer(TimeClosed));
    }
    public void HandState(bool IsClosed)
    {
        Hand.SetBool("Closed", IsClosed);
        Wand.SetActive(true);
        Debug.Log("Handclosed");
    }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        SpawnMagicItems();
        brewingTimer = new MyTimer();
        brewingTimer.OnTimerEnd += BrewingEnd;

        HandTimer = new MyTimer();
        HandTimer.OnTimerEnd += ()=>HandState(false);
    }

    private void Update()
    {





        //if (MagicItemsCounter == 2)
        //{
        //    HandCollider.enabled = true;
        //    MagicItemsCounter = 0;
        //}

        //if (WandMaterialCounter == 5)
        //{
        //    HandCollider.enabled = true;
        //    WandMaterialCounter = 0;
        //}
    }


    public void SpawnMagicItems()
    {
        for (int i = 0; i < MagicItems.Length; i++)
        {
            var item = Instantiate(MagicItems[i].MagicItemPrefab,MagicItems[i].ItemLocation, MagicItems[i].MagicItemPrefab.transform.rotation);
            item.OnItemGot += ItemPickUp;
        }
     
    }
    
    public void ItemPickUp()
    {
        MagicItemsCounter++;
        Debug.Log("Items picked up " + MagicItemsCounter); 
    }
   

   
}

[System.Serializable]
public struct MagicItem
{
    public Vector3 ItemLocation;
    public MagicItemObject MagicItemPrefab;

}