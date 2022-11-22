using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Fire1")) Debug.Log("Fire1");
        if (Input.GetButton("Fire2")) Debug.Log("Fire2");
        if (Input.GetButton("Fire3")) Debug.Log("Fire3");
        if (Input.GetButton("Jump")) Debug.Log("Jump");
    }
}
