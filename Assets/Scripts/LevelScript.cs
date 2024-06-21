using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    public static LevelScript instance;
    public bool HasFirstKey;

    void Start()
    {
        instance = this;
    }


    void Update()
    {

    }
}
