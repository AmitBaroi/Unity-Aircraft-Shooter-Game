using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_charge : MonoBehaviour {

    [SerializeField]
    private Vector3 scale;
    [SerializeField]
    private float startScale = 0.25f;
    [SerializeField]
    private float maxScale = 1.5f;
    [SerializeField]
    private float increaseRate = 0.25f;

    private float ticker = 0.5f;

	void Start ()
    {
        // Setting starting scale
        scale = transform.localScale;
        scale.x = startScale;
        scale.y = startScale;
        transform.localScale = scale;
    }
	
	void Update ()
    {
        // Increasing scale for time elapsed
        scale.x += increaseRate * Time.deltaTime;
        scale.y += increaseRate * Time.deltaTime;
        // Bounding scale to maxScale
        if (scale.x >= maxScale && scale.y >= maxScale)
        {
            scale.x = maxScale;
            scale.y = maxScale;
            transform.localScale = scale;
            // Counting down to release laser blast
            ticker -= Time.deltaTime;
            // Removing charge animatin after ticker ends
            if (ticker <= 0) Destroy(gameObject);
        }
        // Updating localScale
        transform.localScale = scale;
    }
}
