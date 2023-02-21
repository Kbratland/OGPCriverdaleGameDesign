using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class WalkController : MonoBehaviour
{
    public Animator animator;
    NavMeshAgent agent;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 25)
        {
            agent.destination = player.transform.position;
            animator.SetInteger("WalkSwitch",1);
        }
        else{
            agent.destination = this.transform.position;
            animator.SetInteger("WalkSwitch",0);
        }
    }
}
