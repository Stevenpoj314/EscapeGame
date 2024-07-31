using JetBrains.Annotations;
using System.Collections;
using System;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    private Vector3 newVelocity;

    public bool isMove;
    public bool IsPlayerTeleported;

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

        //transform.position += move * Time.deltaTime * speed;
        controller.Move(move * speed * Time.deltaTime);
        
    }

    public void PlayerTeleport(Transform teleportPoint)
    {
        transform.position = teleportPoint.position;

        Debug.Log("Player teleported");
    }

}
