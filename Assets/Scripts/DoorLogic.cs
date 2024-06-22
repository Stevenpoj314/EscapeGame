using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DooLogic : MonoBehaviour
{
    public GameObject ExitDoor;

    private void OnTriggerEnter(Collider Player)
    {
        Debug.Log("Press space to open");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.Space) && LevelScript.instance.HasFirstKey)
        {
            Destroy(ExitDoor);
        }

        else
        {
            Debug.Log("You don't have a key");
        }
    }
}
