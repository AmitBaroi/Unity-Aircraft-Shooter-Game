using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

    [SerializeField]
    private float moveSpeed = 5f;

    private float moveDir;

	void Start ()
    {
        // For player
		if(gameObject.layer == 8)
        {
            moveDir = 1;
        }
        // For enemy
        else if(gameObject.layer == 9)
        {
            moveDir = -1;
        }
        else
        {
            moveDir = 1;
        }


	}
	
	void Update ()
    {
        // Accessing CURRENT position info
        Vector3 pos = transform.position;
        // NEW Position 
        Vector3 velocity = new Vector3(moveDir * moveSpeed * Time.deltaTime, 0, 0);
        // Changing position based on rotation
        pos += transform.rotation * velocity;
        // Updating to NEW position
        transform.position = pos;
    }
}
