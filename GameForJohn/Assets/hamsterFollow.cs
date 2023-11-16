
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class hamsterFollow : MonoBehaviour
{
    public GameObject target;
    public Transform target1;

    public float speed = 15.0f;
    public float rotatespeed = 40f;
    public float chaseRange;
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {

        float speedDelta = speed * Time.deltaTime;
        Vector3 direction = target1.position - transform.position;

        // Vector3 randdirection = new Vector3(Random.Range(1000, -1000), Random.Range(1000, -1000), 0);
        float distance = direction.magnitude;

        if (distance < chaseRange)

        {

            Ray movePosition = Camera.main.ScreenPointToRay(direction);

            if (Physics.Raycast(movePosition, out var hitInfo))
            {

                agent.SetDestination(hitInfo.point);
                //Quaternion rotation = Quaternion.LookRotation(hitInfo.point);
                //transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotatespeed * Time.deltaTime);
            }

            // transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            speed = 0;
        }

    }



    void FaceTarget()
    {
        var turnTowardNavSteeringTarget = agent.steeringTarget;

        Vector3 direction = (turnTowardNavSteeringTarget - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }
}
