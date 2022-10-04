using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    Vector3 startPos;
    public Transform hazard;
    public Transform theKey;
    public Transform[] hazards;
    public AudioClip impact;
    AudioSource audioSource;
    public bool hasKey;
    

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        audioSource = GetComponent<AudioSource>();
        hasKey = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.R)){
           transform.position = startPos;
       }
       if (Input.GetKeyDown(KeyCode.W)){
           print("hello world");
           transform.position += Vector3.forward;
       }

       if (Input.GetKeyDown(KeyCode.S)){
           print("hello world");
           transform.position += Vector3.back;
       }

       if (Input.GetKeyDown(KeyCode.D)){
           print("hello world");
           transform.position += Vector3.right;
       }

        if (Input.GetKeyDown(KeyCode.A)){
           print("hello world");
           transform.position += Vector3.left;
       }
        if (Input.GetKeyDown(KeyCode.Q)){
           print("hello world");
           transform.position += Vector3.down;
       }

        if (Input.GetKeyDown(KeyCode.E)){
           print("hello world");
           transform.position += Vector3.up;
       }
       if (transform.position == theKey.position){
           theKey.gameObject.SetActive(false);
           hasKey = true;
       }
       if (transform.position == hazard.position){
           transform.position = startPos;
           audioSource.PlayOneShot(impact, 0.7F);
       }
        for(int i = 0;i < hazards.Length; i++){
                if (transform.position == hazards[i].position){
                    transform.position = startPos;
                    audioSource.PlayOneShot(impact, 0.7F);
                }
            
        }
    }
}
