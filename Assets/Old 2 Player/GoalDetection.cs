using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Teams
{
	Red,
	Blue
}

public class GoalDetection : MonoBehaviour
{
	public Teams myTeam;
	
	public delegate void GoalScored(GoalDetection goal);
	public event GoalScored GoalEvent;

	void OnTriggerEnter(Collider ball)
	{
		if (ball.gameObject.GetComponent<Ball>() != null)
		{
			GoalEvent?.Invoke(this);
		}
	}
}
