using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : NPC
{
    public float moveSpeed = 1;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player == null)
        {
            Debug.LogError("Player is null");
        }
        setHealth(100);
    }

    void Start()
    { 
        navMeshAgent.speed = moveSpeed;
    }

    void Update()
    {
        MoveToPlayer();
    }
}
