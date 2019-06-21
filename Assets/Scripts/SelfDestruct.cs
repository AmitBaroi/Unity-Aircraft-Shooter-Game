using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

    [SerializeField]
    private float counter = 5f;
    
	void Update ()
    {
        // Reduce counter
        counter -= Time.deltaTime;
        // When counter ends
        if(counter <= 0)
        {
            // Remove object from game
            Destroy(gameObject);
        }
	}
}
