
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class hamsterFollow : MonoBehaviour
{
   
    public Transform player;
    public NavMeshAgent hamster;

    // Update is called once per frame
    void Update()
    {
        hamster.SetDestination(player.position);

    }
}
