using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Supporter : MonoBehaviour
{
	private Teams myTeam;
	float jumpTimer = 0.2f;
	
	private Rigidbody rb;
	private MeshRenderer mr;
	public Material[] teams;

	public GoalDetection[] goal;
	
	private void OnEnable()
	{
		foreach (GoalDetection item in goal)
		{
			item.GoalEvent += React;
		}
	}

	private void Awake()
	{
		if (Random.Range(0, 2) == 0)
		{
			myTeam = Teams.Red;
		}
		else
		{
			myTeam = Teams.Blue;
		}
	}

	// Start is called before the first frame update
    void Start()
    {
	    rb = this.GetComponent<Rigidbody>();
	    mr = this.GetComponent<MeshRenderer>();

	    if (myTeam == Teams.Red)
	    {
		    mr.material = teams[1];
	    }
	    else if (myTeam == Teams.Blue)
	    {
		    mr.material = teams[0];
	    }
    }

    // Update is called once per frame
    void Update()
    {
	    jumpTimer -= Time.deltaTime;	    
	    
	    if (Random.Range(0, 10) == 5 && jumpTimer <= 0)
	    {
		    jumpTimer = 1.1f;
		    rb.AddForce(0, Random.Range(50, 120), 0);
	    }
    }

    void React(GoalDetection goal)
    {
	    if (goal.myTeam != myTeam)
	    {
		    rb.AddForce(0, 300, 0);
	    } 
    }
}
