using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    public Teams myTeam;

    private Rigidbody rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myTeam == Teams.Red)
        {
            Vector3 redMove = new Vector3(Input.GetAxis("HorizRed"), 0, Input.GetAxis("VertRed"));
            rb.AddForce(redMove * 0.02f * Time.deltaTime);
        }

        if (myTeam == Teams.Blue)
        {
            Vector3 blueMove = new Vector3(Input.GetAxis("HorizBlue"), 0, Input.GetAxis("VertBlue"));
            rb.AddForce(blueMove * 0.02f * Time.deltaTime);
        }
    }
}
