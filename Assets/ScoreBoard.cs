using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
	int redScore = 0;
	int blueScore = 0;

	public GoalDetection[] goal = new GoalDetection[2];

	private void OnEnable()
	{
		goal.RedGoal += RedScored;
		goal.BlueGoal += BlueScored;
	}

	void RedScored()
	{
		redScore++;
		print("Red Scored A Goal!!!");
		print("They Now Have: " + redScore + " Points");

	}

	void BlueScored()
	{
		blueScore++;
		print("Blue Scored A Goal!!!");
		print("They Now Have: " + blueScore + " Points");
	}
}
