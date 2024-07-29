using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    private Vector3 newVelocity;

    public bool isMove;
    public bool IsPlayerTeleported;
    Transform MyteleportTransform;

    public void SetPlayerMove()
    {
        isMove = true;
    }


    void Update()
    {
        
        if (IsPlayerTeleported)
        {
            transform.position = MyteleportTransform.position;
            isMove = true;
            IsPlayerTeleported = false;
            Debug.Log("Player has potion");
        }

        if (isMove)
        {
           
            PlayerMove();
        }

       

        if (GameController.Instance.HasFirstKey)
        {
            Debug.Log("Has Key");
        }

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

        controller.Move(move * speed * Time.deltaTime);
    }

    public void PlayerTeleport(Transform teleportTransform)
    {
        isMove = false;

        MyteleportTransform = teleportTransform;

        IsPlayerTeleported = true;


        Debug.Log("Player teleported");
    }

}
