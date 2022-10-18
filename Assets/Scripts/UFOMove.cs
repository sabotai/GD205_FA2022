using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMove : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(Vector3.forward * 10f);
        }
        if (Input.GetKey(KeyCode.S)){
            rb.AddForce(Vector3.back * 10f);
        }
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(Vector3.left * 10f);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(Vector3.right * 10f);
        }
        if (Input.GetKey(KeyCode.E)){
            rb.AddForce(Vector3.up * 10f);
        }
        if (Input.GetKey(KeyCode.Q)){
            rb.AddForce(Vector3.down * 10f);
        }

        if (Input.GetKey(KeyCode.F)){
            rb.velocity *= 0.95f;
        }
    }
}
