using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal 
{
    public string name;
    public int earAmount;
    public int legsAmount;
    public int eyeAmount;
    public int tailAmount;
    public int headAmount;
    public bool hasFur;
    public int teethAmount;

    public Action OnJumped;
    public Action <int> OnFoodAte;

    public void JumpSound()
    {
        Debug.Log("Sound");
    }

    public void FoodAte(int foodAmount)
    {
        Debug.Log("foodAmount =" + foodAmount);
        
    }

    public void Initialize()
    {
        OnJumped +=()=> JumpSound();
        OnFoodAte += (int foodAmount)=> FoodAte(foodAmount);
        OnJumped +=()=> FoodAte(2);
        OnFoodAte +=(int foodAmount)=> JumpSound();

        OnFoodAte?.Invoke(2);
    }

    public virtual void Jump()
    {
        Debug.Log("AnimalJump");
    }

    public virtual void Noise()
    {
        Debug.Log("AnimalNoise");
    }

    public virtual void Run()
    {
        Debug.Log("AnimalRun");
    }

    public virtual void Walk()
    {
        Debug.Log("AnimalWalk");
    }

    public void PrintInfo()
    {
        Debug.Log("Name: " + name);

        Debug.Log("ear Amount: " + earAmount);

        Debug.Log("legs Amount: " + legsAmount);

        Debug.Log("eye Amount: " + eyeAmount);

        Debug.Log("tail Amount: " + tailAmount);

        Debug.Log("head Amount: " + headAmount);

        Debug.Log("teeth Amount: " + teethAmount);
        
        Debug.Log("has fur: " +  hasFur);


    }

}
