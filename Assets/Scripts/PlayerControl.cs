using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    private Vector3 newVelocity;

    private bool isMove;

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

        if (LevelScript.instance.HasFirstKey)
        {
            Debug.Log("Has Key");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            LevelScript.instance.HasFirstKey = true;
        }
    }

    private void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }

}
