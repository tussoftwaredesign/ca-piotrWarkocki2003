using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//Script for the navMeshAgent (hamster) to follow the player
public class hamsterFollow : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent hamster;

    void Update()
    {
        //sets hamsters navMeshAgent destination to the current position of the player
        hamster.SetDestination(player.position);
    }
}
