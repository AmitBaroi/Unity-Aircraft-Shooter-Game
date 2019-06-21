using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDamage : MonoBehaviour {

    [SerializeField]
    private int health = 3;

    [SerializeField]
    private GameObject explosionPrefab;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            health -= 3;
        }
        else
        {
            health--;
        }
    }

    void Update ()
    {
		if(health <= 0)
        {
            Die();
        }
	}

    private void Die()
    {
        // Explode
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        // Remove object
        Destroy(gameObject);
    }
}
