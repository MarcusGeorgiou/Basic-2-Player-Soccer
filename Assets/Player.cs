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
        /*if (myTeam == Teams.Red)
        {
            Vector3 redMove = new Vector3(Input.GetAxis("HorizRed"), 0, Input.GetAxis("VertRed"));
            rb.AddForce(redMove * speed * Time.deltaTime);
            
        }

        if (myTeam == Teams.Blue)
        {
            Vector3 blueMove = new Vector3(Input.GetAxis("HorizBlue"), 0, Input.GetAxis("VertBlue"));
            rb.AddForce(blueMove * speed * Time.deltaTime);
        }
        */
    }
    
    void MovePlayer(InputAction.CallbackContext input)
    {
        print("Moved");
        print(input);
        
        //Something to move players on x and z axes
    }
}
