using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Teams
{
	red,
	blue
}

public class GoalDetection : MonoBehaviour
{
	public delegate void RedScored();
	public event RedScored RedGoal;

	void OnTriggerEnter(Collider ball)
	{
		if(ball.gameObject.GetComponent<Ball>() != null)
		{
			if (goalColour == "red")
			{
				BlueGoal?.Invoke();
			} 
			else if (goalColour == "blue")
			{
				RedGoal?.Invoke();
			}
		}
	}
}
