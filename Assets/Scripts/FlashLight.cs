using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject FlashLightLight;
    public bool FlashLightActive;
    private Vector3 FlashLightMove;
    void Start()
    {
        FlashLightLight.SetActive(false);
    }

  
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E)) 
        {
            if(FlashLightActive == false)
            {
                FlashLightLight.SetActive(true);
                FlashLightActive = true;
            }

            else
            {
                FlashLightLight.SetActive(false);
                FlashLightActive = false;
            }
        }
    }

    private void FlashLightDirection()
    {
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * y;
    }
}
