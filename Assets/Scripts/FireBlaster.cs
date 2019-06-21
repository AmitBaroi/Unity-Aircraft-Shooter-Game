using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBlaster : MonoBehaviour {

    [SerializeField]
    private GameObject chargePrefab;
    [SerializeField]
    private Vector3 offset;

    void Start ()
    {
        ChargeCannon();
    }
	
	void Update ()
    {
        
    }

    private void ChargeCannon()
    {
        Instantiate(chargePrefab, transform.position + offset, transform.rotation);
    }
}
