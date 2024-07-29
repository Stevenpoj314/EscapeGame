using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
    
    

    public IEnumerator StartTimer(float timeValue)
    {
        float TimeCounter = timeValue;
        while (TimeCounter > 0) 
        {
            TimeCounter -= Time.deltaTime;
            yield return null;
        }

        Debug.Log("PotionIsCreated");
        GameController.Instance.Cauldron.SetBool("Open", true);
        yield return null;

        


    }
}
