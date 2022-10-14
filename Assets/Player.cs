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

    private Vector2 redMove;
    private Vector2 blueMove;

    void Awake()
    {
        controls = new Soccer();
        controls.Player.Enable();

        controls.Player.Move.performed += MovePlayer;
    }

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myTeam == Teams.Red)
        {
            //Vector3 redMove = new Vector3(Input.GetAxis("HorizRed"), 0, Input.GetAxis("VertRed"));
            Vector3 rVelocity = new Vector3(redMove.x, 0, redMove.y);
            rb.AddForce(redMove * speed * Time.deltaTime);
        }

        if (myTeam == Teams.Blue)
        {
            //Vector3 blueMove = new Vector3(Input.GetAxis("HorizBlue"), 0, Input.GetAxis("VertBlue"));
            Vector3 bVelocity = new Vector3(blueMove.x, 0, blueMove.y);
            rb.AddForce(bVelocity * speed * Time.deltaTime);
        }
        
    }
    
    void MovePlayer(InputAction.CallbackContext input)
    {
        print("Moved");
        print(input);

        if (myTeam == Teams.Blue)
        {
            blueMove = input.ReadValue<Vector2>();
        }
        else if (myTeam == Teams.Red)
        {
            redMove = input.ReadValue<Vector2>();
        }
    }
}
