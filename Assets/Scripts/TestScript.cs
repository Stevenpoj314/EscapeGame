using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public bool pen;
    public bool pencil;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pen || pencil)
        {
            Debug.Log("write");
        }
    }
}
