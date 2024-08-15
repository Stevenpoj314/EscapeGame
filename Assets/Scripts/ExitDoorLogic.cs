using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorLogic : MonoBehaviour
{
    public GameObject DoorLock;
    public float StartRotate;
    public float EndRotate;

    public void OnTriggerEnter(Collider other)
    {
       
         if (GameController.Instance.IsHasDoorPotion)
         {
            Destroy(DoorLock);
         }
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.Space) && GameController.Instance.IsHasDoorPotion)
        {
            StartCoroutine(DoorRotate());
          
        }

        else
        {
            Debug.Log("You don't have potion");
        }
    }

    private IEnumerator DoorRotate()
    {
        for (float i = StartRotate; i < EndRotate; i++)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, i, transform.rotation.z);
            //transform.Rotate(transform.rotation.x, i, transform.rotation.z);
            yield return null;

        }


    }
}
