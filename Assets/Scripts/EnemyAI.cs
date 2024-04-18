using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Tracking.Follow.Modifier.Property.Rotation;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 1f; // Speed at which the enemy moves
    public float moveDistance = 5f; // Distance the enemy moves from its starting position
    //public float moveRotation = 180;
    private Vector3 startPosition; // The starting position of the enemy
    private Vector3 endPosition; // The end position of the enemy
    private bool movingRight = true; // Boolean to track the enemy's movement direction

    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + Vector3.right * moveDistance;
    }

    void Update()
    {
        // Move the enemy towards the end position if moving right, else move it towards the start position
        Vector3 targetPosition = movingRight ? endPosition : startPosition;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        //transform.rotation = Vector3.RotateTowards(transform.rotation, targetPosition, RotateAroundAngularVelocity *Time.deltaTime);

        // Check if the enemy has reached the target position, then change direction
        if (transform.position == targetPosition)
        {
            movingRight = !movingRight;
        }
    }
}
