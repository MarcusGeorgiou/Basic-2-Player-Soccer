using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    private bool playerSpawned;
    
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    public void KeyPressed()
    {
        if (playerSpawned)
        {
            ChangeColour();
        }
        else
        {
            Spawn();
        }
    }
    
    private void Spawn()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        playerSpawned = true;
    }

    public delegate void ChangeColourEvent();
    public event ChangeColourEvent changeColourEvent;
    
    private void ChangeColour()
    {
        changeColourEvent?.Invoke();
    }
}
