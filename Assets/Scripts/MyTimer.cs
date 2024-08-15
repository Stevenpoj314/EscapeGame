using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTimer 
{

    public Action OnTimerEnd;

   
    public IEnumerator StartTimer(float timeValue)
    {
        Debug.Log("StartTimer");
        float TimeCounter = timeValue;
        while (TimeCounter > 0) 
        {
            TimeCounter -= Time.deltaTime;
            yield return null;
            
        }
        

        Debug.Log("TimeIsOver");
        OnTimerEnd?.Invoke();
       // GameController.Instance.Cauldron.SetBool("Open", true);
        yield return null;

    }

    
}
