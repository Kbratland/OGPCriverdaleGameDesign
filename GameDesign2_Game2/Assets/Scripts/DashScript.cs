using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    public FirstPersonController firstPersonController;
    Rigidbody rb;
    bool counting = false;
    float eTime = 0;
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
        }
        if(counting){
            eTime += Time.deltaTime;
        }
    }
    void Dash()
    {
        firstPersonController.enabled = !firstPersonController.enabled;
        rb.useGravity = false;
        counting = true;
        if(eTime > 2){
            firstPersonController.enabled = firstPersonController.enabled;
            rb.useGravity = true;
        }
    }
}
