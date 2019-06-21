using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTake : MonoBehaviour {

    [SerializeField]
    private float health = 1f;

    [SerializeField]
    private GameObject explosionPrefab;

    // When collider is triggered
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.layer == 9 && collision.gameObject.layer == 10)
        {
            return;
        }
        // Reduce health
        health--;
        if (gameObject.name == "Player") Debug.Log(gameObject.name + " Damaged! Health: " + health);
    }

    private void Update()
    {
        // Death Condition
        if(health <= 0)
        {
            Die();
        }
        
    }

    private void Die()
    {
        if(explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }

        // Remove object from game
        Destroy(gameObject);
    }
}
