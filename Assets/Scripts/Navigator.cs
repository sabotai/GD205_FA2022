using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigator : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast( laser, out hit)){
            if (Input.GetMouseButtonDown(0)){
                agent.SetDestination(hit.point); 
            }

        }
    }

    void OnTriggerStay(Collider col){

        //agent.SetDestination(target.position);
    }
}
