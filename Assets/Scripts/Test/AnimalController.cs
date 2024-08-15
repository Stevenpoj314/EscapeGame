using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    public Dog dog;

    public void Start()
    {
        dog = new Dog();

        dog.hasFur = true;
        dog.legsAmount = 4;
        dog.earAmount = 2;
        dog.name = "dog";
        dog.Jump();
    }
}
