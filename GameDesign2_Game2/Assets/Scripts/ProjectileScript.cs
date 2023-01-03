using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float eTime;
    public GameObject player;
    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        eTime += Time.deltaTime;
        if(eTime > 3f)
        {
            RB.AddForce(new Vector3(0,1,0));
        }
    }
}
