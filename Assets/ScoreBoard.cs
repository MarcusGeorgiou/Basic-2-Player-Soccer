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

	void RedPoint()
	{
		redScore++;
		print("Red Scored A Goal!!!");
		print("They Now Have: " + redScore + " Points");

	}

	void BluePoint()
	{
		blueScore++;
		print("Blue Scored A Goal!!!");
		print("They Now Have: " + blueScore + " Points");
	}
}
