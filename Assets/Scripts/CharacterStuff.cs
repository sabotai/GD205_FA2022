using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStuff : MonoBehaviour
{
    CharacterController controller;
    public Animator anim;
    public float walkSpeed = 5f;
    public float runSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Debug.Log(move);
        float moveSpeed = walkSpeed;
        if (Input.GetButton("Fire3")){
            moveSpeed = runSpeed;
        }

        controller.Move(move * Time.deltaTime * moveSpeed);

        anim.SetFloat("ZSpeed", controller.velocity.z);
    }
}
