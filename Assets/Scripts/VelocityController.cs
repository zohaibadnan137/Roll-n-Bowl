using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityController : MonoBehaviour
{
    public float velocity = 25;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(rb.velocity.z < velocity)
        {
            Vector3 forward = new Vector3(0f, 0f, velocity * 1.25f);
            rb.AddForce(forward);
        }
    }
}
