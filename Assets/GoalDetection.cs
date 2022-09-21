using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDetection : MonoBehaviour
{
	public string goalColour;
	public ScoreBoard addPoints;

	void OnTriggerEnter(Collider ball)
	{
		if(ball.gameObject.GetComponent<Ball>() != null)
		{
			Goal();
		}
	}
	
	void Goal()
	{
		if(goalColour == "red")
		{
			addPoints.GoalScored("blue");			
		}
		else if(goalColour == "blue")
		{
			addPoints.GoalScored("red");
		}

	}
}
