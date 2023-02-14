using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeController : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public float radius = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if( Vector3.Distance(transform.position, player.transform.position) <= radius){
            // animator.Switch1 = true;
            if(animator != null){
                animator.SetBool("Switch1",true);
                player.GetComponent<healthScript>().health -= 10;
                Debug.Log($"animing");
            }
        }
    }
}
