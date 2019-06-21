using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySineMove : MonoBehaviour {

    [SerializeField]
    private float moveXDir = 1, moveYDir = 1;
    [SerializeField]
    private float horizontalSpeed = 2f;
    [SerializeField]
    private float verticalSpeed = 1.5f;
    [SerializeField]
    private float amplitude = 3.5f;
    [SerializeField]
    private float sinePower = 1;
    private Vector3 tempPosition;

	void Start ()
    {
        // Current position of object
        tempPosition = transform.position;
	}
	
	void FixedUpdate ()
    {
        // Change X axis
        tempPosition.x += moveXDir * horizontalSpeed * Time.deltaTime;
        // Change Y axis as a Sine of X (Time.realtimeSinceStartup gives the time elapsed since start of the game)
        tempPosition.y += moveYDir * Mathf.Pow(Mathf.Sin(verticalSpeed * Time.realtimeSinceStartup), sinePower) * amplitude * Time.deltaTime;
        // Update position
        transform.position = tempPosition;
    }
}
