using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public GoalDetection[] goal;
	private Rigidbody rb;
	
	private void OnEnable()
	{
		foreach (GoalDetection item in goal)
		{
			item.GoalEvent += ResetPosition;
		}

		rb = this.GetComponent<Rigidbody>();
	}

	void ResetPosition(GoalDetection goal)
	{
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
		this.transform.position = new Vector3(0, 3, 0);
	}
}
