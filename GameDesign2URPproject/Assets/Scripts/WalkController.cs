using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class WalkController : MonoBehaviour
{
    public Animator animator;
    NavMeshAgent agent;
    public GameObject player;
    AudioSource audioSource;
    // bool damaged = false;
    float eTime;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        eTime += Time.deltaTime;
        if(Vector3.Distance(transform.position, player.transform.position) <= 25 && Vector3.Distance(transform.position, player.transform.position) >= 4)
        {
            agent.destination = player.transform.position;
            animator.SetInteger("AnimSwitch",1);
            audioSource.Play();
            // damaged = false;
        }
        else if (Vector3.Distance(transform.position, player.transform.position) <= 4){
            rand = Random.Range(0,2);
            Debug.Log(rand);
            if(rand == 1){
                animator.SetInteger("AnimSwitch", 3);
            }
            else if (rand == 0){
                animator.SetInteger("AnimSwitch", 4);
            }
            if(eTime > 1.25)
                {
                    player.GetComponent<healthScript>().health -= 5;
                    eTime = 0;
                }

        }
        else if (Vector3.Distance(transform.position, player.transform.position) > 25 ){
            agent.destination = this.transform.position;
            animator.SetInteger("WalkSwitch",0);
            audioSource.Stop();
        }
    }
}
