using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Vector3 bulletOffset = new Vector3(-0.5f, 0, 0);

    private Transform player;

    [SerializeField]
    private float cooldownDuration = 0.75f;
    private float cooldown = 0f;

    private float fireDistance = 12f;
    private bool inRange;

    void Start ()
    {
        // Set initial values
        cooldown = cooldownDuration;
        inRange = false;
	}
	
	void Update ()
    {
        FindPlayer();
        InRange();
        
        // Reduce cooldown
        cooldown -= Time.deltaTime;
        
        // Shoot condition
        if(cooldown <= 0 && inRange)
        {
            // Spawn bullet
            Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
            // Reset cooldown
            cooldown = cooldownDuration;
        }


	}

    private void FindPlayer()
    {
        if(player == null)
        {
            GameObject go = GameObject.Find("Player");
            if(go != null)
            {
                player = go.transform;
            }
        }
        if (player == null) return;
    }

    private void InRange()
    {
        float dist = Vector3.Distance(transform.position, player.position);
        if (dist < fireDistance)
        {
            inRange = true;
        }
        if (dist > fireDistance)
        {
            inRange = false;
        }
    }

}
