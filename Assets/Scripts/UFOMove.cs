using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMove : MonoBehaviour
{
    Rigidbody rb;
    public float forceForSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(Vector3.forward * forceForSpeed);
        }
        if (Input.GetKey(KeyCode.S)){
            rb.AddForce(Vector3.back * forceForSpeed);
        }
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(Vector3.left * forceForSpeed);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(Vector3.right * forceForSpeed);
        }
        if (Input.GetKey(KeyCode.E)){
            rb.AddForce(Vector3.up * forceForSpeed);
        }
        if (Input.GetKey(KeyCode.Q)){
            rb.AddForce(Vector3.down * forceForSpeed);
        }

        if (Input.GetKey(KeyCode.F)){
            rb.velocity *= 0.95f;
        }
        
    }

    void OnCollisionEnter(Collision colReport){
        Debug.Log("YOU ARE HIT! " + colReport.gameObject.name); //same as print()
        //if (colReport.gameObject.tag == "enemy"){
            GetComponent<ParticleSystem>().Play();
        //}
    }
}
