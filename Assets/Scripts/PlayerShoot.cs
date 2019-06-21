using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Vector3 bulletOffset = new Vector3 (0.5f, 0, 0);

    [SerializeField]
    private float cooldownDuration = 0.5f;
    private float cooldown = 0f;

    void Start ()
    {
        cooldown = 0f;
    }

    void Update ()
    {
        // Reduce cooldown
        cooldown -= Time.deltaTime;

        // Shoot condition (Replace GetKey with GetButton later)
        if(Input.GetKey(KeyCode.Space) && cooldown <= 0)
        {
            // Spawn bullet
            Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
            // Reset cooldown
            cooldown = cooldownDuration;
        }
	}
}
