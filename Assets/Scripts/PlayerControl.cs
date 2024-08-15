using JetBrains.Annotations;
using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    public float SizeX = 0.2342233f;
    public float SizeY = 0.2181281f;
    public float SizeZ = 0.2531526f;

    public Vector3 OriginalSize;

    private Vector3 newVelocity;
    //private Vector3 scaleChange;

    public bool isMove;
    public bool IsPlayerTeleported;
    public GameObject FlashLight;

    public void Start()
    {
        OriginalSize = transform.localScale;
    }

    public void BackToNormalSize()
    {
        transform.localScale = OriginalSize;
    }
    public void SetFlashLightActivity(bool isActive)
    {
        FlashLight.SetActive(isActive);
    }

   
    public void SetPlayerMove()
    {
        isMove = true;
    }

    void Update()
    {
        if (isMove)
        {
            PlayerMove();
        }


        //if (GameController.Instance.HasFirstKey)
        //{
        //    Debug.Log("Has Key");
        //}

        
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    GameController.Instance.HasFirstKey = true;
        //}
    }
    private void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        //transform.position += move * Time.deltaTime * speed;
        controller.Move(move * speed * Time.deltaTime);
        
    }

    public void PlayerTeleport(Transform teleportPoint)
    {
        transform.position = teleportPoint.position;

        Debug.Log("Player teleported");

        if (GameController.Instance.IsHasShrinkPotion)
        {
           GameController.Instance.player.transform.localScale = new Vector3(SizeX,SizeY, SizeZ);

        }

    }

    
}
