using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolVertical : MonoBehaviour {

    [SerializeField]
    private float moveSpeed = 3.5f;
    [SerializeField]
    private float moveRange = 3f;

    private Vector3 currentPosition;
    private float moveDir;

	void Start ()
    {
        // Setting random initial direction
        moveDir = Random.Range(-1, 1);
        if (moveDir == 0)
        {
            moveDir = 1f;
        }
	}
	
	void Update ()
    {
        // Get current position
        currentPosition = transform.position;

        // Chaning Y axis
        currentPosition.y += moveDir * moveSpeed * Time.deltaTime;

        // Update position
        transform.position = currentPosition;

        // Move distance limit
        if(currentPosition.y >= moveRange || currentPosition.y <= -moveRange)
        {
            moveDir *= -1f;
        }
    }
}
