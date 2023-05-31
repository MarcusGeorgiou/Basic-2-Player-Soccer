using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    public void spawn()
    {
        Instantiate(player, transform.position, Quaternion.identity);
    }
}
