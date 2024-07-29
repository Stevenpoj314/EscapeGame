using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLogic : MonoBehaviour
{
    public float StartRotate;
    public float EndRotate;

    private void OnTriggerEnter(Collider Player)
    {
        //Debug.Log("Press space to open");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.Space) && GameController.Instance.HasFirstKey)
        {
            StartCoroutine(DoorRotate());
            // Debug.Log("Door unlocked");
        }

        else
        {
            Debug.Log("You don't have a key");
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
