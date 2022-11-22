using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimClickNavigator : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast( laser, out hit) && Input.GetMouseButtonDown(0)){
            agent.SetDestination(hit.point); 
        }

        if (agent.velocity == Vector3.zero){
            anim.SetBool("Run", false);
        } else {
            anim.SetBool("Run", true);
        }
    }

}
