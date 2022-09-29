using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
	int redScore = 0;
	int blueScore = 0;

	public GoalDetection[] goal;

	public delegate void UpdateScore(int newScore, GoalDetection goal);
	public event UpdateScore UIEvent;

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
			
			UIEvent?.Invoke(blueScore, goalDetection);
		}
		else if (goalDetection.myTeam == Teams.Blue)
		{
			redScore++;
			print("Red Scored A Goal!!!");
			print("They Now Have: " + redScore + " Points");

			UIEvent?.Invoke(redScore, goalDetection);
		}
	}
}
