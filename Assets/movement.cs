using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;

    public float force = 2000f;
    // Start is called before the first frame update
    // void Start()
    // {

    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s"))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
