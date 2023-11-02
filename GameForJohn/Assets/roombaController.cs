using UnityEngine;

public class roombaController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotationSpeed = 90f;
    public float detectionRadius = 1f;
    public LayerMask obstacleLayer;

    private Transform roombaTransform;
    private bool obstacleDetected = false;
    private Vector3 targetRotation;

    private void Start()
    {
        roombaTransform = transform;
    }

    private void Update()
    {
        if (!obstacleDetected)
        {
            MoveForward();
        }
        else
        {
            RotateToAvoidObstacle();
        }
    }

    private void MoveForward()
    {
        roombaTransform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        CheckForObstacle();
    }

    private void CheckForObstacle()
    {
        RaycastHit hit;
        if (Physics.Raycast(roombaTransform.position, roombaTransform.forward, out hit, detectionRadius, obstacleLayer))
        {
            obstacleDetected = true;
            targetRotation = new Vector3(0f, Random.Range(0f, 360f), 0f);
        }
    }

    private void RotateToAvoidObstacle()
    {
        Quaternion targetRotationQuaternion = Quaternion.Euler(targetRotation);
        roombaTransform.rotation = Quaternion.RotateTowards(roombaTransform.rotation, targetRotationQuaternion, rotationSpeed * Time.deltaTime);

        if (Quaternion.Angle(roombaTransform.rotation, targetRotationQuaternion) < 1f)
        {
            obstacleDetected = false;
        }
    }
}
