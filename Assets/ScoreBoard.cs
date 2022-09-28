using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
	int redScore = 0;
	int blueScore = 0;

	public GoalDetection[] goal;

	private void OnEnable()
	{
		foreach (GoalDetection item in goal)
		{
			item.GoalEvent += PointScored;
		}
	}

	private void PointScored(GoalDetection goalDetection)
	{
		if (goalDetection.myTeam == Teams.Red)
		{
			blueScore++;
			print("Blue Scored A Goal!!!");
			print("They Now Have: " + blueScore + " Points");
		}
		else if (goalDetection.myTeam == Teams.Blue)
		{
			redScore++;
			print("Red Scored A Goal!!!");
			print("They Now Have: " + redScore + " Points");
		}
	}
}
