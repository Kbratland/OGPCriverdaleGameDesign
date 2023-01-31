using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{

    public ParticleSystem dust;
    public ParticleSystem dust2;
    public ParticleSystem dust3;
    public ParticleSystem dust4;
    public FirstPersonController firstPersonController;
    public Rigidbody rb;
    float eTime;
    bool dashing;
    bool grounded = true;
    public float speed;
    public float duration = 0.5f;
    public bool freeze;
    void Start()
    {

    }

    void Update()
    {
        if(firstPersonController.isGrounded){
            grounded = true;
        }
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
                // firstPersonController.enableHeadBob = true;
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
        CreateDust();
        firstPersonController.playerCanMove = false;
        //  firstPersonController.enableHeadBob = false;
        rb.useGravity = false;
        rb.AddForce(transform.forward * speed);
    }
    void CreateDust()
    {
        dust.Play();
        dust2.Play();
        dust3.Play();
        dust4.Play();
    }
}
