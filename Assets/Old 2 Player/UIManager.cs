using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Teams myScore;
    public ScoreBoard scores;

    private void OnEnable()
    {
       scores.UIEvent += UpdateScore;
    }

    private void UpdateScore(int newScore, GoalDetection goal)
    {
        if (goal.myTeam != myScore)
        {
            this.GetComponent<TextMeshProUGUI>().text = (myScore + ": " + newScore);
            Debug.Log("score updated for team " + myScore);
        }
    }
}
