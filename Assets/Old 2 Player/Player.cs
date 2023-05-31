using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Teams myTeam;

    private Rigidbody rb;
    public float speed;
    
    Soccer controls;

    private Vector2 moveValue;
    void Awake()
    {
        controls = new Soccer();
        controls.Player.Enable();

        if (myTeam == Teams.Red)
        {
            controls.Player.RedMove.performed += MovePlayer;
            controls.Player.RedMove.canceled += MovePlayer;
        }
        else if(myTeam == Teams.Blue)
        {
            controls.Player.BlueMove.performed += MovePlayer;
            controls.Player.BlueMove.canceled += MovePlayer;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            Vector3 velocity = new Vector3(moveValue.x, 0, moveValue.y);
            rb.AddForce(velocity * speed);
    }
    
    void MovePlayer(InputAction.CallbackContext input)
    {
        moveValue = input.ReadValue<Vector2>();
    }
}
