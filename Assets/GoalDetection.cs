using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDetection : MonoBehaviour
{
	public string goalColour;

	public delegate void RedScored();
	public event RedScored RedGoal;
	
	public delegate void BlueScored();
	public event BlueScored BlueGoal;
	
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
