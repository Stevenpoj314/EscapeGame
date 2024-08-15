using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLogic : MonoBehaviour
{
    public Light PointLight;
  public BoxCollider FuseBox;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Light turn on");
        GameController.Instance.IsHasFuse = true;
        PointLight.enabled = true;  
    }
}
