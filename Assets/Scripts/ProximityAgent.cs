using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityAgent : MonoBehaviour
{
	Rigidbody rb;
	public Transform prey;
	public float proxDistance = 20f;
	public float forceAmt = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(prey.position, transform.position) < proxDistance){
        	Debug.Log("BEEP BEEP PROXIMITY TRIGGERED!!!");
        	Vector3 preyDirection = Vector3.Normalize(prey.position - transform.position);
        	rb.AddForce(preyDirection * forceAmt);
        }
    }
}
