using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    public FirstPersonController firstPersonController;
    public Rigidbody rb;
    float eTime;
    bool dashing;
    public float speed;
    public float duration = 0.5f;
    public bool freeze;
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && !dashing)
        {
            eTime = 0;
            Dash();
            dashing = true;
        }
        if(dashing)
        {
            eTime += Time.deltaTime;
            if( eTime > duration){
                firstPersonController.playerCanMove = true;
                firstPersonController.enableHeadBob = true;
                if(freeze)
                {
                    rb.velocity = UnityEngine.Vector3.zero;
                }
                rb.useGravity = true;
                eTime = 0;
                
            }
        }
    }
    void Dash()
    {
        firstPersonController.playerCanMove = false;
        firstPersonController.enableHeadBob = false;
        rb.useGravity = false;
        rb.AddForce(transform.forward * speed);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "GROUND"){
            dashing = false;
        }
    }
}
