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
    public bool grounded;
    public float speed;
    public float duration = 0.5f;
    public bool freeze;
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && !dashing && grounded)
        {
            eTime = 0;
            Dash();
            dashing = true;
            grounded = false;
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
                dashing = false;
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
        if(other.gameObject.tag == "ground"){
            grounded = true;
        }
        if(other.gameObject.layer == 3 && dashing){
            grounded = true;
        }
    }
}
