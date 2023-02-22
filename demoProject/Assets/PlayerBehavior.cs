using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    int frameCount = 0;
    float speed = 5f;
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            transform.position = transform.position - (transform.right * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.D)){
            transform.position = transform.position - (transform.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W)){
            transform.position = transform.position - (transform.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S)){
            transform.position = transform.position - (transform.forward * Time.deltaTime * speed);
        }
    }
}