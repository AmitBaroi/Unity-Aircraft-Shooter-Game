using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    [SerializeField]
    private float moveSpeed = 5f;

    protected float horizon;
    protected float vertical;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        // Getting Input (Returns float from -1.0 to +1.0)
        horizon = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        // Allerting Animator for movement animations
        anim.SetFloat("speedVertical", vertical);
        
        // Accessing CURRENT position
        Vector3 pos = transform.position;
        // Changin X axis
        pos.x += horizon * moveSpeed * Time.deltaTime;
        // Chaning Y axis
        pos.y += vertical * moveSpeed * Time.deltaTime;
        // Updating to NEW position
        transform.position = pos;
    }

    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public float GetHor()
    {
        return horizon;
    }

    public float GetVer()
    {
        return vertical;
    }

}
