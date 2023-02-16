using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeController : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public float radius = 7.5f;
    bool damaged = false;
    bool started = false;
    int limit =0;
    float eTime = 0;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
         audioSource = GetComponent<AudioSource>();
         audioSource.Play();
        started = false;
        damaged = false;
    }

    // Update is called once per frame
    void Update()
    {
        if( Vector3.Distance(transform.position, player.transform.position) <= radius){
            // animator.Switch1 = true;
            if(animator != null){
                started = true;
                animator.SetBool("Switch1",true);
                if(damaged == false)
                {
                    player.GetComponent<healthScript>().health -= 25;
                    // Debug.Log($"damaging");
                    // Debug.Log(limit);
                    if(limit <=7 ){
                        damaged = true;
                    }
                }
                Debug.Log($"boomed");
            }
        }
        if(started){
            eTime += 0.05f;
            // Debug.Log("eTime is " + eTime);
            if(eTime >= 9f){
                Destroy(this.gameObject);
            }
        }
    }
}
