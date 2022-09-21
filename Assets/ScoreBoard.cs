using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
	int redScore = 0;
	int blueScore = 0;
	
	public void GoalScored(string player)
	{
		if(player == "red")
		{
			redScore++;
			print("Red Scored A Goal!!!");
			print("They Now Have: " + redScore + " Points");
		}
		else if(player == "blue")
		{
			blueScore++;
			print("Blue Scored A Goal!!!");
			print("They Now Have: " + blueScore + " Points");
		}
	}
}
