using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandMaterialLogic : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameController.Instance.WandMaterialCounter++;
        Destroy(gameObject);
        GameController.Instance.IsHasWandMaterial = true;

    }
}