using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerView : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.instance.changeColourEvent += ChangeColour;
    }

    private void ChangeColour()
    {
        GetComponent<Renderer>().material.color =
            new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
    }
}
