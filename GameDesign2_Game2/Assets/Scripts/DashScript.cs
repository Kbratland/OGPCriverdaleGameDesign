using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    public FirstPersonController firstPersonController;
    Rigidbody rb;
    float eTime;
    bool dashing;
    public float speed;
    float duration = 1;
    void Start()
    {
        firstPersonController = GetComponent<FirstPersonController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Dash();
            dashing = true;
        }
        if(dashing)
        {
            eTime += Time.deltaTime;
            if( eTime > duration){
                firstPersonController.enabled = firstPersonController.enabled;
                rb.useGravity = true;
            }
        }
    }
    void Dash()
    {
        firstPersonController.enabled = !firstPersonController.enabled;
        rb.useGravity = false;
        rb.AddForce(transform.forward * speed);
    }
}
