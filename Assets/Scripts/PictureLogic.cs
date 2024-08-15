using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureLogic : MonoBehaviour
{
    public GameObject picture;
    public Animator Key;
   
    public void OnTriggerEnter(Collider other)
    {
        if(GameController.Instance.IsHasFireBoy == false)
        {
           Destroy(picture);
           Key.SetBool("Start", true);
           
        }
        
    }
}
