using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthScript : MonoBehaviour
{
    public int health = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0)
        {

        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "projectile")
        {
            health -= 1;
            Destroy(other.gameObject);
        }
    }
}