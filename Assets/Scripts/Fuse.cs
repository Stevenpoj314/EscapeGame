using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    public GameObject fuse;
    public void OnTriggerEnter(Collider other)
    {
        Destroy(fuse);
    }
}
