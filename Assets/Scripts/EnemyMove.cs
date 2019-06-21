using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    [SerializeField]
    private float moveSpeed = 3.5f;
    private int rand;
    private bool moving;

    /*      DEPRICATED VERSION
     * 
     *  Putting the random number generator in the update method
     *  seems to create vibrating, jittery movement.
     *  Explore available solution.
     */




    void Start()
    {
        moving = false;
    }

    void Update ()
    {
        Vector3 currPos = transform.position;

        rand = Random.Range(-1, 2);

        Vector3 targPos = currPos + new Vector3(0, rand * moveSpeed, 0);

        if (!moving)
        {
            transform.position = Vector3.MoveTowards(currPos, targPos, moveSpeed * Time.deltaTime);
        }
        if(Vector3.Distance(currPos, targPos) <= 0.5f)
        {
            moving = false;
        }
        
    }

}
