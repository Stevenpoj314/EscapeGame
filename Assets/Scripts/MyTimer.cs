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
            return null;
        }

        GameController.Instance.Cauldron.SetBool("Brewing", false);
        return null;


    }
}
